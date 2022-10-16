using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using MuOnline.Database.Entities.Entites;
using MuOnline.Database.Repositories;
using MuOnline.Infrastructure.Core.Exceptions;
using MuOnline.Infrastructure.Core.Models;
using MuOnline.Services.System.Dtos;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MuOnline.Services.System
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IConfiguration _config;
        private readonly IRepository<MembInfo> _membInfoRepository;
        public UserService(
            UserManager<AppUser> userManager, 
            SignInManager<AppUser> signInManager,
            RoleManager<AppRole> roleManager,
            IConfiguration config,
            IRepository<MembInfo> membInfoRepository)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager =  roleManager;
            _config = config;
            _membInfoRepository = membInfoRepository;
        }
        public async Task<ResponseBase<LoginUserRespone>> LoginUser(LoginUserRequest request)
        {
            var user = await _userManager.FindByNameAsync(request.UserName);

            if (user == null) throw new AuthenticationException("UserName not exists");

            var result = await _signInManager.PasswordSignInAsync(user, request.PasswordWeb, request.RememberMe, true);

            if (!result.Succeeded) throw new AuthenticationException("Password incorrect");

            var roles = await _userManager.GetRolesAsync(user);

            var claims = new[]
            {
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.GivenName, user.UserName),
                new Claim(ClaimTypes.Role, String.Join(";", roles)),
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                _config["Jwt:Issuer"],
                _config["Jwt:Issuer"],
                claims,
                expires: DateTime.Now.AddHours(3),
                signingCredentials: creds);

            var data = new LoginUserRespone
            { 
                Token = new JwtSecurityTokenHandler().WriteToken(token)
            };

            return new ResponseBase<LoginUserRespone>(){ Data = data };
        }

        public async Task<ResponseBase<bool>> RegisterUser(RegisterUserRequest request)
        {
            var user = await _userManager.FindByNameAsync(request.UserName);
            var membinfoQuery = _membInfoRepository.GetAll().Where(x => x.MembId == request.UserName).FirstOrDefault();
            var error = new ErrorModel();

            if (user != null || membinfoQuery != null)
            {
                error.ErrorCode = 409;
                error.Message = "Username already exists";

                return new ResponseBase<bool>() { Error = error };
            }
            if (await _userManager.FindByEmailAsync(request.Email) != null)
            {
                error.Message = "Email already exists";
                return new ResponseBase<bool>() { Error = error };
            }

            user = new AppUser()
            {
                Email = request.Email,
                UserName = request.UserName,
                PhoneNumber = request.PhoneNumber
            };

            //Create User for Web
            var result = await _userManager.CreateAsync(user, request.PasswordWeb);
            if (result.Succeeded)
            {
                var membinfo = new MembInfo()
                {
                    MembId = request.UserName,
                    MembName = request.UserName,
                    MembPwd = request.PasswordGame,
                    SnoNumb = request.PasswordGame,
                    MailAddr = request.Email,
                    BlocCode = "0",
                    Ctl1Code = "0",
                    AccountLevel = 0
                };

                // Create user ingame
                var membInfoResult = _membInfoRepository.Insert(membinfo);
                if (result == null)
                {
                    return new ResponseBase<bool>() { Error = new ErrorModel { ErrorCode = 100, Message = "Registration failed" } };
                }
                
            }
            return new ResponseBase<bool>() { };
        }
    }
}
