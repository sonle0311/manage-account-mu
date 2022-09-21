using System;
using System.Collections.Generic;

namespace MuOnline.Database.Entities.Entites
{
    public partial class Marry
    {
        public string Character { get; set; } = null!;
        public string MarryCharacter { get; set; } = null!;
        public DateTime MarriedOn { get; set; }
    }
}
