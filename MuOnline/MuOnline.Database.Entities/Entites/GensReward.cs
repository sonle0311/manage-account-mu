using System;
using System.Collections.Generic;

namespace MuOnline.Database.Entities.Entites
{
    public partial class GensReward
    {
        public string Name { get; set; } = null!;
        public int? Rank { get; set; }
        public int? Status { get; set; }
    }
}
