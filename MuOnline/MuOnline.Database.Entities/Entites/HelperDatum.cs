using System;
using System.Collections.Generic;

namespace MuOnline.Database.Entities.Entites
{
    public partial class HelperDatum
    {
        public string Name { get; set; } = null!;
        public byte[]? Data { get; set; }
    }
}
