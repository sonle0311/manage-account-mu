using System;
using System.Collections.Generic;

namespace MuOnline.Database.Entities.Entites
{
    public partial class MuCastleMoneyStatistic
    {
        public int MapSvrGroup { get; set; }
        public DateTime LogDate { get; set; }
        public decimal MoneyChange { get; set; }
    }
}
