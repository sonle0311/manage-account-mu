using System;
using System.Collections.Generic;

namespace MuOnline.Database.Entities.Entites
{
    public partial class TPetItemInfo
    {
        public int ItemSerial { get; set; }
        public short? PetLevel { get; set; }
        public int? PetExp { get; set; }
    }
}
