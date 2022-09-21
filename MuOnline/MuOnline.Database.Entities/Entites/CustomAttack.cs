using System;
using System.Collections.Generic;

namespace MuOnline.Database.Entities.Entites
{
    public partial class CustomAttack
    {
        public string Name { get; set; } = null!;
        public short Active { get; set; }
        public short? Skill { get; set; }
        public short? Map { get; set; }
        public short? PosX { get; set; }
        public short? PosY { get; set; }
        public short? AutoBuff { get; set; }
        public short? OffPvP { get; set; }
        public short? AutoReset { get; set; }
        public int? AutoAddStr { get; set; }
        public int? AutoAddAgi { get; set; }
        public int? AutoAddVit { get; set; }
        public int? AutoAddEne { get; set; }
        public int? AutoAddCmd { get; set; }
    }
}
