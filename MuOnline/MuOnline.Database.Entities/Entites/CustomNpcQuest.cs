using System;
using System.Collections.Generic;

namespace MuOnline.Database.Entities.Entites
{
    public partial class CustomNpcQuest
    {
        public string Name { get; set; } = null!;
        public int Quest { get; set; }
        public int Count { get; set; }
        public int MonsterCount { get; set; }

        public virtual Character NameNavigation { get; set; } = null!;
    }
}
