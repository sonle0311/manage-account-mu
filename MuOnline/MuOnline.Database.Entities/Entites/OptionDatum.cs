using System;
using System.Collections.Generic;

namespace MuOnline.Database.Entities.Entites
{
    public partial class OptionDatum
    {
        public string Name { get; set; } = null!;
        public byte[]? SkillKey { get; set; }
        public byte? GameOption { get; set; }
        public byte? Qkey { get; set; }
        public byte? Wkey { get; set; }
        public byte? Ekey { get; set; }
        public byte? ChatWindow { get; set; }
        public byte? Rkey { get; set; }
        public int? Qwerlevel { get; set; }
    }
}
