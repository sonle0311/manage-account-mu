using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MuOnline.Services.System;
using MuOnline.Services.System.Dtos;

namespace MuOnline.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginUser([FromBody]LoginUserRequest request)
        {
            var result = await _userService.LoginUser(request);
            return Ok(result);
        }

        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] RegisterUserRequest request)
        {
            var result = await _userService.RegisterUser(request);
            return Ok(result);
        }
    }
}
