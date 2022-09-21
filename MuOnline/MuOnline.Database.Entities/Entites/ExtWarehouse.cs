using System;
using System.Collections.Generic;

namespace MuOnline.Database.Entities.Entites
{
    public partial class ExtWarehouse
    {
        public string AccountId { get; set; } = null!;
        public byte[]? Items { get; set; }
        public int? Money { get; set; }
        public int? Number { get; set; }
    }
}
