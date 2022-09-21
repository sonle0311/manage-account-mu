using System;
using System.Collections.Generic;

namespace MuOnline.Database.Entities.Entites
{
    public partial class Character
    {
        public Character()
        {
            CustomNpcQuests = new HashSet<CustomNpcQuest>();
        }

        public string AccountId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int? CLevel { get; set; }
        public int? LevelUpPoint { get; set; }
        public byte? Class { get; set; }
        public int? Experience { get; set; }
        public int? Strength { get; set; }
        public int? Dexterity { get; set; }
        public int? Vitality { get; set; }
        public int? Energy { get; set; }
        public int? Leadership { get; set; }
        public byte[]? Inventory { get; set; }
        public byte[]? MagicList { get; set; }
        public int? Money { get; set; }
        public float? Life { get; set; }
        public float? MaxLife { get; set; }
        public float? Mana { get; set; }
        public float? MaxMana { get; set; }
        public float? Bp { get; set; }
        public float? MaxBp { get; set; }
        public float? Shield { get; set; }
        public float? MaxShield { get; set; }
        public short? MapNumber { get; set; }
        public short? MapPosX { get; set; }
        public short? MapPosY { get; set; }
        public byte? MapDir { get; set; }
        public int? PkCount { get; set; }
        public int? PkLevel { get; set; }
        public int? PkTime { get; set; }
        public DateTime? Mdate { get; set; }
        public DateTime? Ldate { get; set; }
        public byte? CtlCode { get; set; }
        public byte? DbVersion { get; set; }
        public byte[]? Quest { get; set; }
        public short? ChatLimitTime { get; set; }
        public int? FruitPoint { get; set; }
        public byte[]? EffectList { get; set; }
        public int FruitAddPoint { get; set; }
        public int FruitSubPoint { get; set; }
        public int ResetCount { get; set; }
        public int MasterResetCount { get; set; }
        public int ExtInventory { get; set; }
        public int Kills { get; set; }
        public int Deads { get; set; }
        public DateTime? BlocExpire { get; set; }
        public int TheGift { get; set; }
        public int Rdmg { get; set; }
        public int Rdef { get; set; }
        public int Rcrit { get; set; }
        public int Rexc { get; set; }
        public int Rdouble { get; set; }
        public int Rlife { get; set; }
        public int Rmana { get; set; }
        public int Lvtuchan { get; set; }
        public int Relifes { get; set; }
        public int Lvdanhhieu { get; set; }
        public int ChaosBank { get; set; }
        public int BlessBank { get; set; }
        public int SoulBank { get; set; }
        public int LifeBank { get; set; }
        public int CreateonBank { get; set; }
        public int GuardianBank { get; set; }
        public int HarmonyBank { get; set; }
        public int LowStoneBank { get; set; }
        public int HighStoneBank { get; set; }
        public int GemStoneBank { get; set; }
        public int Zen { get; set; }
        public int ResetsTime { get; set; }

        public virtual CustomQuest? CustomQuest { get; set; }
        public virtual ICollection<CustomNpcQuest> CustomNpcQuests { get; set; }
    }
}
