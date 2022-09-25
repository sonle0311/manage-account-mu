using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MuOnline.Database.Migrations
{
    public partial class SeedRoleandSystemAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("d6c2760a-e99d-4dd2-8fb7-9fec75436fee"), new Guid("1c07e700-0574-461c-a3c5-7006db7ec144") });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("0cf484a8-a8cb-4f4f-9785-ad53f199eb85"), "06c83035-db8a-4fa3-bd6b-d31b1876f5af", "Customer", "Customer" },
                    { new Guid("d52ab115-016a-42a1-ac77-70d55af021b1"), "276922ca-2302-4355-a338-253916d3a27d", "Admin", "Admin" },
                    { new Guid("d6c2760a-e99d-4dd2-8fb7-9fec75436fee"), "ffe95ca8-40f9-4f5c-9c33-7c4f8c478361", "System Admin", "System Admin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("1c07e700-0574-461c-a3c5-7006db7ec144"), 0, "89836510-2163-4c97-bc4a-bb2410e64f70", "lethanhson.hcmus@gmail.com", true, false, null, "lethanhson.hcmus@gmail.com", "admin", "AQAAAAEAACcQAAAAEEZWwpqwA3tblgB3aAydzONVEEQ2DKWisf0gX9RKxjWem7V4Fd2AgM/wbBmE2zxaFw==", null, false, "", false, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("d6c2760a-e99d-4dd2-8fb7-9fec75436fee"), new Guid("1c07e700-0574-461c-a3c5-7006db7ec144") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0cf484a8-a8cb-4f4f-9785-ad53f199eb85"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d52ab115-016a-42a1-ac77-70d55af021b1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d6c2760a-e99d-4dd2-8fb7-9fec75436fee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c07e700-0574-461c-a3c5-7006db7ec144"));
        }
    }
}
