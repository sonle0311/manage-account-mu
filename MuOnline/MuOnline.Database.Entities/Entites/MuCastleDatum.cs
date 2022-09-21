using System;
using System.Collections.Generic;

namespace MuOnline.Database.Entities.Entites
{
    public partial class MuCastleDatum
    {
        public int MapSvrGroup { get; set; }
        public DateTime SiegeStartDate { get; set; }
        public DateTime SiegeEndDate { get; set; }
        public bool SiegeGuildlistSetted { get; set; }
        public bool SiegeEnded { get; set; }
        public bool CastleOccupy { get; set; }
        public string OwnerGuild { get; set; } = null!;
        public decimal Money { get; set; }
        public int TaxRateChaos { get; set; }
        public int TaxRateStore { get; set; }
        public int TaxHuntZone { get; set; }
    }
}
