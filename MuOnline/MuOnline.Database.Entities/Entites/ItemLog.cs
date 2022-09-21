using System;
using System.Collections.Generic;

namespace MuOnline.Database.Entities.Entites
{
    public partial class ItemLog
    {
        public int Seq { get; set; }
        public string? Acc { get; set; }
        public string? Name { get; set; }
        public byte[]? ItemCode { get; set; }
        public int? Sn { get; set; }
        public string? IName { get; set; }
        public string? ILvl { get; set; }
        public short? ISkill { get; set; }
        public short? ILuck { get; set; }
        public string? IExt { get; set; }
        public short? ISet { get; set; }
        public short? I380 { get; set; }
        public short? IJh { get; set; }
        public DateTime? SentDate { get; set; }
    }
}
