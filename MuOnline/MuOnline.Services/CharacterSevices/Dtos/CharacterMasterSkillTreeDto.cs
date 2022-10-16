using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuOnline.Services.CharacterSevices.Dtos
{
    public class CharacterMasterSkillTreeDto
    {
        public string AccountName { get; set; }
        public string CharacterName { get; set; }
        public byte? CharacterClass { get; set; }
        public int? Level { get; set; }
        public int? MasterLevel { get; set; }
        public int? FreePoint { get; set; }
        public int? MasterPonit { get; set; }
        public int? Strength { get; set; }
        public int? Agility { get; set; }
        public int? Vitality { get; set; }
        public int? Energy { get; set; }
        public int? Command { get; set; }
    }
}
