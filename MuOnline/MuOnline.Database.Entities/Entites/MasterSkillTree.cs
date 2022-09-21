using System;
using System.Collections.Generic;

namespace MuOnline.Database.Entities.Entites
{
    public partial class MasterSkillTree
    {
        public string Name { get; set; } = null!;
        public int? MasterLevel { get; set; }
        public int? MasterPoint { get; set; }
        public long? MasterExperience { get; set; }
        public byte[]? MasterSkill { get; set; }
    }
}
