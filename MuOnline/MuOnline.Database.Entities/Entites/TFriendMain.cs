using System;
using System.Collections.Generic;

namespace MuOnline.Database.Entities.Entites
{
    public partial class TFriendMain
    {
        public int Guid { get; set; }
        public string Name { get; set; } = null!;
        public byte? FriendCount { get; set; }
        public int? MemoCount { get; set; }
        public int? MemoTotal { get; set; }
    }
}
