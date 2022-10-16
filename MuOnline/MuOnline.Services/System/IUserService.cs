using MuOnline.Infrastructure.Core.Models;
using MuOnline.Services.Abstractions;
using MuOnline.Services.System.Dtos;

namespace MuOnline.Services.System
{
    public  interface IUserService : IBaseService
    {
        Task<ResponseBase<LoginUserRespone>> LoginUser(LoginUserRequest request);
        Task<ResponseBase<bool>> RegisterUser(RegisterUserRequest request);
    }
}
