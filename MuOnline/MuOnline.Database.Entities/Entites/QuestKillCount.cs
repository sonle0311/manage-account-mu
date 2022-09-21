using System;
using System.Collections.Generic;

namespace MuOnline.Database.Entities.Entites
{
    public partial class QuestKillCount
    {
        public string Name { get; set; } = null!;
        public int? QuestIndex { get; set; }
        public int? MonsterClass1 { get; set; }
        public int? KillCount1 { get; set; }
        public int? MonsterClass2 { get; set; }
        public int? KillCount2 { get; set; }
        public int? MonsterClass3 { get; set; }
        public int? KillCount3 { get; set; }
        public int? MonsterClass4 { get; set; }
        public int? KillCount4 { get; set; }
        public int? MonsterClass5 { get; set; }
        public int? KillCount5 { get; set; }
    }
}
