using System;
using System.Collections.Generic;

namespace MuOnline.Database.Entities.Entites
{
    public partial class Guild
    {
        public string GName { get; set; } = null!;
        public byte[]? GMark { get; set; }
        public int? GScore { get; set; }
        public string? GMaster { get; set; }
        public int? GCount { get; set; }
        public string? GNotice { get; set; }
        public int Number { get; set; }
        public int GType { get; set; }
        public int GRival { get; set; }
        public int GUnion { get; set; }
        public int? MemberCount { get; set; }
    }
}
