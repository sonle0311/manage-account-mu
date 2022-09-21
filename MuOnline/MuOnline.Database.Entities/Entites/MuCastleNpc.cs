using System;
using System.Collections.Generic;

namespace MuOnline.Database.Entities.Entites
{
    public partial class MuCastleNpc
    {
        public int MapSvrGroup { get; set; }
        public int NpcNumber { get; set; }
        public int NpcIndex { get; set; }
        public int NpcDfLevel { get; set; }
        public int NpcRgLevel { get; set; }
        public int NpcMaxhp { get; set; }
        public int NpcHp { get; set; }
        public byte NpcX { get; set; }
        public byte NpcY { get; set; }
        public byte NpcDir { get; set; }
        public DateTime NpcCreatedate { get; set; }
    }
}
