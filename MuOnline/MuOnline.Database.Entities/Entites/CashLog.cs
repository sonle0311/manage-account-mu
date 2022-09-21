using System;
using System.Collections.Generic;

namespace MuOnline.Database.Entities.Entites
{
    public partial class CashLog
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? SentDate { get; set; }
    }
}
