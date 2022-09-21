using System;
using System.Collections.Generic;

namespace MuOnline.Database.Entities.Entites
{
    public partial class GensRank
    {
        public string Name { get; set; } = null!;
        public int? Family { get; set; }
        public int? Contribution { get; set; }
    }
}
