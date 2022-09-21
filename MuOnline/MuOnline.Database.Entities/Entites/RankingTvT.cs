using System;
using System.Collections.Generic;

namespace MuOnline.Database.Entities.Entites
{
    public partial class RankingTvT
    {
        public string Name { get; set; } = null!;
        public int Kills { get; set; }
        public int Deads { get; set; }
    }
}
