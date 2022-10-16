using MuOnline.Infrastructure.Core.Models;
using MuOnline.Services.Abstractions;
using MuOnline.Services.CharacterSevices.Dtos;

namespace MuOnline.Services.CharacterSevices
{
    public interface ICharacterService : IBaseService
    {
        Task<ResponseBase<GetCharacterByNameReponse>> GetCharacterByCharacterName(GetCharacterByNameRequest request);
        Task<ResponseBase<UpdateCharacterByCharacterNameReponse>> UpdateCharacterByCharacterName(UpdateCharacterByCharacterNameRequest request);
    }
}
