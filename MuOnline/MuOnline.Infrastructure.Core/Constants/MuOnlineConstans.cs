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
    }
}
