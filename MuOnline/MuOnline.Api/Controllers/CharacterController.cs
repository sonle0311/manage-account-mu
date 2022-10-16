using Microsoft.AspNetCore.Mvc;
using MuOnline.Services.CharacterSevices;
using MuOnline.Services.CharacterSevices.Dtos;
using MuOnline.Services.System.Dtos;

namespace MuOnline.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;
        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpPost("get-character-by-character-name")]
        public async Task<IActionResult> GetCharacterByCharacterName([FromBody] GetCharacterByNameRequest request)
        {
            var result = await _characterService.GetCharacterByCharacterName(request);
            return Ok(result);
        }

        [HttpPost("update-character-by-character-name")]
        public async Task<IActionResult> UpdateCharacterByCharacterName([FromBody] UpdateCharacterByCharacterNameRequest request)
        {
            var result = await _characterService.UpdateCharacterByCharacterName(request);
            return Ok(result);
        }
    }
}
