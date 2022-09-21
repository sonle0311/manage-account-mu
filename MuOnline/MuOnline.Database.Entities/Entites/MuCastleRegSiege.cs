using System;
using System.Collections.Generic;

namespace MuOnline.Database.Entities.Entites
{
    public partial class MuCastleRegSiege
    {
        public int MapSvrGroup { get; set; }
        public string RegSiegeGuild { get; set; } = null!;
        public int RegMarks { get; set; }
        public byte IsGiveup { get; set; }
        public int SeqNum { get; set; }
    }
}
