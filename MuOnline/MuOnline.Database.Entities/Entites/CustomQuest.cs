using System;
using System.Collections.Generic;

namespace MuOnline.Database.Entities.Entites
{
    public partial class CustomQuest
    {
        public string Name { get; set; } = null!;
        public int Quest { get; set; }

        public virtual Character NameNavigation { get; set; } = null!;
    }
}
