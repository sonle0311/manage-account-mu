using System;
using System.Collections.Generic;

namespace MuOnline.Database.Entities.Entites
{
    public partial class TFriendList
    {
        public int Guid { get; set; }
        public int? FriendGuid { get; set; }
        public string? FriendName { get; set; }
        public byte? Del { get; set; }
    }
}
