using System;
using System.Collections.Generic;

namespace MuOnline.Database.Entities.Entites
{
    public partial class CashShopDatum
    {
        public string AccountId { get; set; } = null!;
        public int? WcoinC { get; set; }
        public int? WcoinP { get; set; }
        public int? GoblinPoint { get; set; }
        public int Ruud { get; set; }
    }
}
