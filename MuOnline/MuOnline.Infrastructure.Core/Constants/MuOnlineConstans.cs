using System.ComponentModel;

namespace MuOnline.Infrastructure.Core.Constants
{
    public static class MuOnlineConstans
    {
        public static class Role
        {
            public static readonly Guid System_Admin_Id = Guid.Parse("d6c2760a-e99d-4dd2-8fb7-9fec75436fee");
            public static readonly string System_Admin_Name = "System Admin";

            public static readonly Guid Admin_Id = Guid.Parse("d52ab115-016a-42a1-ac77-70d55af021b1");
            public static readonly string Admin_Name = "Admin";

            public static readonly Guid Customer_Id = Guid.Parse("0cf484a8-a8cb-4f4f-9785-ad53f199eb85");
            public static readonly string Customer_Name = "Customer";
        }

        public static class CharacterClass1
        {
            public static readonly byte Dark_Wizard = 0;
            public static readonly byte Soul_Master = 1;
            public static readonly byte Grand_Master = 2;
            public static readonly byte Dark_Knight = 16;
            public static readonly byte Blade_Knight = 17;
            public static readonly byte Blade_Master = 18;
            public static readonly byte Fairy_Elf = 32;
            public static readonly byte Muse_Elf = 33;
            public static readonly byte Hight_Elf = 34;
            public static readonly byte Summoner = 80;
            public static readonly byte Bloody_Summoner = 81;
            public static readonly byte Dimension_Master = 82;
            public static readonly byte Macgic_Gladiator = 48;
            public static readonly byte Duel_Master = 50;
            public static readonly byte Dark_Lord = 64;
            public static readonly byte Lord_Emperor = 66;
            public static readonly byte Rage_Lord = 96;
            public static readonly byte[] Lord_Fighter = new byte[] {97, 98};
        }

        public enum CharacterClass
        {
            [Description("Dark Wizard")]
            Dark_Wizard = 0,
            [Description("Soul Master")]
            Soul_Master = 1,
            [Description("Grand Master")]
            Grand_Master = 2,
            [Description("Dark Knight")]
            Dark_Knight = 16,
            [Description("Blade Knight")]
            Blade_Knight = 17,
            [Description("Blade Master")]
            Blade_Master = 18,
            [Description("Fairy Elf")]
            Fairy_Elf = 32,
            [Description("Muse Elf")]
            Muse_Elf = 33,
            [Description("Hight Elf")]
            Hight_Elf = 34,
            [Description("Summoner")]
            Summoner = 80,
            [Description("Bloody Summoner")]
            Bloody_Summoner = 81,
            [Description("Dimension Master")]
            Dimension_Master = 82,
            [Description("Macgic Gladiator")]
            Macgic_Gladiator = 48,
            [Description("Duel Master")]
            Duel_Master = 50,
            [Description("Dark Lord")]
            Dark_Lord = 64,
            [Description("Lord Emperor")]
            Lord_Emperor = 66,
            [Description("Rage Lord")]
            Rage_Lord = 96,
            [Description("Lord Fighter")]
            Lord_Fighter = 97
        }
    }
}
