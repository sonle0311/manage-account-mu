using System;
using System.Collections.Generic;

namespace MuOnline.Database.Entities.Entites
{
    public partial class GuildMember
    {
        public string Name { get; set; } = null!;
        public string GName { get; set; } = null!;
        public byte? GLevel { get; set; }
        public byte GStatus { get; set; }
    }
}
