﻿using System;
using System.Collections.Generic;

namespace MuOnline.Database.Entities.Entites
{
    public partial class AccountCharacter
    {
        public int Number { get; set; }
        public string Id { get; set; } = null!;
        public string? GameId1 { get; set; }
        public string? GameId2 { get; set; }
        public string? GameId3 { get; set; }
        public string? GameId4 { get; set; }
        public string? GameId5 { get; set; }
        public string? GameIdc { get; set; }
        public byte? MoveCnt { get; set; }
        public int ExtClass { get; set; }
        public int ExtWarehouse { get; set; }
    }
}
