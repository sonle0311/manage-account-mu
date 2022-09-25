using MuOnline.Services.Abstractions;
using MuOnline.Services.System.Dtos;

namespace MuOnline.Services.System
{
    public  interface IUserService : IBaseService
    {
        Task<string> LoginUser(LoginUserRequest request);
        Task<bool> RegisterUser(RegisterUserRequest request);
    }
}
