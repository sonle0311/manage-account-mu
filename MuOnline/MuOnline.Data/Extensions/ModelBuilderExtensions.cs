using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MuOnline.Database.Entities.Entites;
using MuOnline.Infrastructure.Core.Constants;

namespace MuOnline.Database.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppRole>().HasData(
                new AppRole
                {
                    Id = MuOnlineConstans.Role.System_Admin_Id,
                    Name = MuOnlineConstans.Role.System_Admin_Name,
                    NormalizedName = MuOnlineConstans.Role.System_Admin_Name
                },
                new AppRole
                {
                    Id = MuOnlineConstans.Role.Admin_Id,
                    Name = MuOnlineConstans.Role.Admin_Name,
                    NormalizedName = MuOnlineConstans.Role.Admin_Name
                },
                new AppRole
                {
                    Id = MuOnlineConstans.Role.Customer_Id,
                    Name = MuOnlineConstans.Role.Customer_Name,
                    NormalizedName = MuOnlineConstans.Role.Customer_Name
                });

            var systemAdminId = new Guid("1c07e700-0574-461c-a3c5-7006db7ec144");
            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = systemAdminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "lethanhson.hcmus@gmail.com",
                NormalizedEmail = "lethanhson.hcmus@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Admin@123"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = MuOnlineConstans.Role.System_Admin_Id,
                UserId = systemAdminId
            });
        }


    }
}
