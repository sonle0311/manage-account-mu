using System;
using System.Collections.Generic;

namespace MuOnline.Database.Entities.Entites
{
    public partial class Warehouse
    {
        public string AccountId { get; set; } = null!;
        public byte[]? Items { get; set; }
        public int? Money { get; set; }
        public DateTime? EndUseDate { get; set; }
        public byte? DbVersion { get; set; }
        public short? Pw { get; set; }
    }
}
