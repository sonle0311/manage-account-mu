using System;
using System.Collections.Generic;

namespace MuOnline.Database.Entities.Entites
{
    public partial class MembInfo
    {
        public int MembGuid { get; set; }
        public string MembId { get; set; } = null!;
        public string MembPwd { get; set; } = null!;
        public string MembName { get; set; } = null!;
        public string SnoNumb { get; set; } = null!;
        public string? PostCode { get; set; }
        public string? AddrInfo { get; set; }
        public string? AddrDeta { get; set; }
        public string? TelNumb { get; set; }
        public string? PhonNumb { get; set; }
        public string? MailAddr { get; set; }
        public string? FpasQues { get; set; }
        public string? FpasAnsw { get; set; }
        public string? JobCode { get; set; }
        public DateTime? ApplDays { get; set; }
        public DateTime? ModiDays { get; set; }
        public DateTime? OutDays { get; set; }
        public DateTime? TrueDays { get; set; }
        public string? MailChek { get; set; }
        public string BlocCode { get; set; } = null!;
        public string Ctl1Code { get; set; } = null!;
        public int AccountLevel { get; set; }
        public DateTime AccountExpireDate { get; set; }
        public int Lock { get; set; }
        public DateTime? BlocExpire { get; set; }
    }
}
