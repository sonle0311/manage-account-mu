using System;
using System.Collections.Generic;

namespace MuOnline.Database.Entities.Entites
{
    public partial class TFriendMail
    {
        public int MemoIndex { get; set; }
        public int Guid { get; set; }
        public string? FriendName { get; set; }
        public DateTime WDate { get; set; }
        public string? Subject { get; set; }
        public bool BRead { get; set; }
        public byte[]? Memo { get; set; }
        public byte[]? Photo { get; set; }
        public byte? Dir { get; set; }
        public byte? Act { get; set; }
    }
}
