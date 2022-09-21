using System;
using System.Collections.Generic;

namespace MuOnline.Database.Entities.Entites
{
    public partial class MuCastleSiegeGuildlist
    {
        public int MapSvrGroup { get; set; }
        public string GuildName { get; set; } = null!;
        public int GuildId { get; set; }
        public bool GuildInvolved { get; set; }
        public int GuildScore { get; set; }
    }
}
