using MuOnline.Database.Entities.Entites;
using MuOnline.Database.Repositories;
using MuOnline.Database.UnitOfWork;
using MuOnline.Infrastructure.Core.Constants;
using MuOnline.Infrastructure.Core.Extensions;
using MuOnline.Infrastructure.Core.Models;
using MuOnline.Services.CharacterSevices.Dtos;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace MuOnline.Services.CharacterSevices
{
    public class CharacterService : ICharacterService
    {
        private readonly IRepository<Character> _characterRepository;
        private readonly IRepository<MasterSkillTree> _masterSkillTreeRepository;
        private readonly IUnitOfWork _unitOfWork;
        public CharacterService(IRepository<Character> characterRepository,
            IRepository<MasterSkillTree> masterSkillTreeRepository,
            IUnitOfWork unitOfWork)
        {
            _characterRepository = characterRepository;
            _masterSkillTreeRepository = masterSkillTreeRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<ResponseBase<GetCharacterByNameReponse>> GetCharacterByCharacterName(GetCharacterByNameRequest request)
        {
            var response = new ResponseBase<GetCharacterByNameReponse>();

            var character = _characterRepository.GetAll().ToList();
            var masterSkillTree = _masterSkillTreeRepository.GetAll().ToList();

            var characterMasterSkillTree = (from ch in character
                                            join mtst in masterSkillTree on ch.Name equals mtst.Name
                                            where ch.AccountId == request.AccountName && ch.Name == request.CharacterName
                                            select new CharacterMasterSkillTreeDto
                                            {
                                                CharacterName = ch.Name,
                                                AccountName = ch.AccountId,
                                                CharacterClass = ch.Class,
                                                Level = ch.CLevel,
                                                FreePoint = ch.LevelUpPoint,
                                                MasterLevel = mtst.MasterLevel,
                                                MasterPonit = mtst.MasterPoint,
                                                Strength = ch.Strength,
                                                Agility = ch.Dexterity,
                                                Vitality = ch.Vitality,
                                                Energy = ch.Energy,
                                                Command = ch.Leadership
                                            }).FirstOrDefault();
            if (character == null) 
            {
                response.Error = new ErrorModel { ErrorCode = 404, Message = "Character not exist" };
                return response;
            }

            response.Data = new GetCharacterByNameReponse
            {
                CharacterName = characterMasterSkillTree.CharacterName,
                AccountName = characterMasterSkillTree.AccountName,
                CharacterClassName = GetCharacterClassName(characterMasterSkillTree.CharacterClass),
                Level = characterMasterSkillTree.Level.Value,
                FreePoint = characterMasterSkillTree.FreePoint.Value,
                MasterLevel = characterMasterSkillTree.MasterLevel.Value,
                MasterPonit = characterMasterSkillTree.MasterPonit.Value,
                Strength = characterMasterSkillTree.Strength.Value,
                Agility = characterMasterSkillTree.Agility.Value,
                Vitality = characterMasterSkillTree.Vitality.Value,
                Energy = characterMasterSkillTree.Energy.Value,
                Command = characterMasterSkillTree.Command.Value
            };

            return response;
        }

        public async Task<ResponseBase<UpdateCharacterByCharacterNameReponse>> UpdateCharacterByCharacterName(UpdateCharacterByCharacterNameRequest request)
        {
            var response = new ResponseBase<UpdateCharacterByCharacterNameReponse>();

            var character = _characterRepository.GetAll().FirstOrDefault(x => x.AccountId == request.AccountName && x.Name == request.CharacterName);
            var masterSkillTree = _masterSkillTreeRepository.GetAll().FirstOrDefault(x => x.Name == request.CharacterName);

            if (character == null || masterSkillTree == null)
            {
                response.Error = new ErrorModel { ErrorCode = 404, Message = "Character not exist" };
                return response;
            }

            character.CLevel = request.Level ?? character.CLevel;
            character.LevelUpPoint = request.FreePoint ?? character.LevelUpPoint;
            character.Strength = request.Strength ?? character.Strength;
            character.Dexterity = request.Agility ?? character.Dexterity;
            character.Vitality = request.Vitality ?? character.Vitality;
            character.Energy = request.Energy ?? character.Energy;
            character.Leadership = request.Command ?? character.Leadership;

            masterSkillTree.MasterLevel = request.MasterLevel ?? masterSkillTree.MasterLevel;
            masterSkillTree.MasterPoint = request.MasterPonit ?? masterSkillTree.MasterPoint;

            _characterRepository.Update(character);
            _masterSkillTreeRepository.Update(masterSkillTree);

            if (_unitOfWork.Commit() != 0)
            {
                response.Error = new ErrorModel { ErrorCode = 500, Message = "Cannot update data" };
            }

            response.Data = new UpdateCharacterByCharacterNameReponse
            {
                AccountName = character.AccountId,
                CharacterName = character.Name,
                CharacterClassName = GetCharacterClassName(character.Class),
                Level = character.CLevel.Value,
                FreePoint = character.LevelUpPoint.Value,
                MasterLevel = masterSkillTree.MasterLevel.Value,
                MasterPonit = masterSkillTree.MasterPoint.Value,
                Strength = character.Strength.Value,
                Agility = character.Dexterity.Value,
                Vitality = character.Vitality.Value,
                Energy = character.Energy.Value,
                Command = character.Leadership.Value
            };

            return response;
        }

        private string GetCharacterClassName(byte? characterClass)
        {
            if (characterClass.Value == (byte)MuOnlineConstans.CharacterClass.Dark_Wizard)
            {
                return MuOnlineConstans.CharacterClass.Dark_Wizard.GetDescriptionTypeEnum();
            }

            if (characterClass.Value == (byte)MuOnlineConstans.CharacterClass.Soul_Master)
            {
                return MuOnlineConstans.CharacterClass.Soul_Master.GetDescriptionTypeEnum();
            }

            if (characterClass.Value == (byte)MuOnlineConstans.CharacterClass.Grand_Master)
            {
                return MuOnlineConstans.CharacterClass.Grand_Master.GetDescriptionTypeEnum();
            }

            if (characterClass.Value == (byte)MuOnlineConstans.CharacterClass.Dark_Knight)
            {
                return MuOnlineConstans.CharacterClass.Dark_Knight.GetDescriptionTypeEnum();
            }

            if (characterClass.Value == (byte)MuOnlineConstans.CharacterClass.Blade_Knight)
            {
                return MuOnlineConstans.CharacterClass.Blade_Knight.GetDescriptionTypeEnum();
            }

            if (characterClass.Value == (byte)MuOnlineConstans.CharacterClass.Blade_Master)
            {
                return MuOnlineConstans.CharacterClass.Blade_Master.GetDescriptionTypeEnum();
            }

            if (characterClass.Value == (byte)MuOnlineConstans.CharacterClass.Fairy_Elf)
            {
                return MuOnlineConstans.CharacterClass.Fairy_Elf.GetDescriptionTypeEnum();
            }

            if (characterClass.Value == (byte)MuOnlineConstans.CharacterClass.Muse_Elf)
            {
                return MuOnlineConstans.CharacterClass.Muse_Elf.GetDescriptionTypeEnum();
            }

            if (characterClass.Value == (byte)MuOnlineConstans.CharacterClass.Hight_Elf)
            {
                return MuOnlineConstans.CharacterClass.Hight_Elf.GetDescriptionTypeEnum();
            }

            if (characterClass.Value == (byte)MuOnlineConstans.CharacterClass.Summoner)
            {
                return MuOnlineConstans.CharacterClass.Summoner.GetDescriptionTypeEnum();
            }

            if (characterClass.Value == (byte)MuOnlineConstans.CharacterClass.Bloody_Summoner)
            {
                return MuOnlineConstans.CharacterClass.Bloody_Summoner.GetDescriptionTypeEnum();
            }

            if (characterClass.Value == (byte)MuOnlineConstans.CharacterClass.Dimension_Master)
            {
                return MuOnlineConstans.CharacterClass.Dimension_Master.GetDescriptionTypeEnum();
            }

            if (characterClass.Value == (byte)MuOnlineConstans.CharacterClass.Macgic_Gladiator)
            {
                return MuOnlineConstans.CharacterClass.Macgic_Gladiator.GetDescriptionTypeEnum();
            }

            if (characterClass.Value == (byte)MuOnlineConstans.CharacterClass.Duel_Master)
            {
                return MuOnlineConstans.CharacterClass.Duel_Master.GetDescriptionTypeEnum();
            }

            if (characterClass.Value == (byte)MuOnlineConstans.CharacterClass.Dark_Lord)
            {
                return MuOnlineConstans.CharacterClass.Dark_Lord.GetDescriptionTypeEnum();
            }

            if (characterClass.Value == (byte)MuOnlineConstans.CharacterClass.Lord_Emperor)
            {
                return MuOnlineConstans.CharacterClass.Lord_Emperor.GetDescriptionTypeEnum();
            }

            if (characterClass.Value == (byte)MuOnlineConstans.CharacterClass.Rage_Lord)
            {
                return MuOnlineConstans.CharacterClass.Rage_Lord.GetDescriptionTypeEnum();
            }

            if (characterClass.Value == (byte)MuOnlineConstans.CharacterClass.Lord_Fighter)
            {
                return MuOnlineConstans.CharacterClass.Lord_Fighter.GetDescriptionTypeEnum();
            }

            return string.Empty;
        }
    }
}
