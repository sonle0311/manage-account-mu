using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MuOnline.Database.Entities.Entites;
using MuOnline.Infrastructure.Core.Exceptions;
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
        public UserService(
            UserManager<AppUser> userManager, 
            SignInManager<AppUser> signInManager,
            RoleManager<AppRole> roleManager,
            IConfiguration config)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager =  roleManager;
            _config = config;
        }
        public async Task<string> LoginUser(LoginUserRequest request)
        {
            var user = await _userManager.FindByNameAsync(request.UserName);

            if (user == null) throw new AuthenticationException("UserName not exists");

            var result = await _signInManager.PasswordSignInAsync(user, request.PasswordWeb1, request.RememberMe, true);

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
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public Task<bool> RegisterUser(RegisterUserRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
