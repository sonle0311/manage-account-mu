using System;
using System.Collections.Generic;

namespace MuOnline.Database.Entities.Entites
{
    public partial class RankingDevilSquare
    {
        public string Name { get; set; } = null!;
        public int? Score { get; set; }
        public int ScoreSemanal { get; set; }
    }
}
