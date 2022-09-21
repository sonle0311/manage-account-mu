using System;
using System.Collections.Generic;

namespace MuOnline.Database.Entities.Entites
{
    public partial class GameServerInfo
    {
        public int Number { get; set; }
        public int ItemCount { get; set; }
        public int? ZenCount { get; set; }
        public int? AceItemCount { get; set; }
    }
}
