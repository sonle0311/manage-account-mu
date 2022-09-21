using System;
using System.Collections.Generic;

namespace MuOnline.Database.Entities.Entites
{
    public partial class RankingDuel
    {
        public string Name { get; set; } = null!;
        public int? WinScore { get; set; }
        public int? LoseScore { get; set; }
        public int WinScoreSemanal { get; set; }
    }
}
