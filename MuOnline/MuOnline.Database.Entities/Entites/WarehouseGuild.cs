using System;
using System.Collections.Generic;

namespace MuOnline.Database.Entities.Entites
{
    public partial class WarehouseGuild
    {
        public string Guild { get; set; } = null!;
        public byte[]? Items { get; set; }
        public int? Money { get; set; }
        public DateTime? EndUseDate { get; set; }
        public byte? DbVersion { get; set; }
        public short? Pw { get; set; }
        public int StatusRender { get; set; }
    }
}
