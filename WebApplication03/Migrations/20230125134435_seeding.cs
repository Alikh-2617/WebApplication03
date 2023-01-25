using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication03.Migrations
{
    public partial class seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "801d6c6e-db4b-4824-afa6-a0715207b2c1", "94c061d0-7c87-43f5-88cc-5ee8129b0f33", "User", "USER" },
                    { "a3440661-8c9c-4682-9a51-862bb61d2e07", "7e05fdd9-00b1-41b4-ad85-7a4e16f94d67", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "EfterName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PicPath", "Register", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "869b55d6-1031-4d31-92b0-d5782d372109", 0, 0, "8b7c02e3-037b-4023-8f51-49b2c7de213a", "Adminson", "admin@admin.com", false, false, null, "Admin", "ADMIN@ADMIN.COM", "ADMIN1@ADMIN.COM", "AQAAAAEAACcQAAAAEOy/Sm98HVCvNjJI9a6hb1PUSLfrDWVKohgk3Gf9974rDyJ3StIA3CuvxRikFo4ULw==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4378d374-78e6-49c8-9ff1-b69351d6090a", false, "admin1@admin.com" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "Name", "PostNumber", "Register" },
                values: new object[,]
                {
                    { "0daae921-d6aa-4f53-af71-f065f4417ac0", null, "Järpen", "415 55", new DateTime(2023, 1, 25, 14, 44, 35, 202, DateTimeKind.Local).AddTicks(7565) },
                    { "64a88fb0-4b13-4048-99f7-2f1953b09e9f", null, "GBG", "415 52", new DateTime(2023, 1, 25, 14, 44, 35, 202, DateTimeKind.Local).AddTicks(7559) },
                    { "9260f1c2-b890-435a-aaa8-10c0852209b1", null, "Mörsil", "415 44", new DateTime(2023, 1, 25, 14, 44, 35, 202, DateTimeKind.Local).AddTicks(7572) }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[,]
                {
                    { "b3454965-35fb-446c-9a30-4c6cce683379", "Danmarc", new DateTime(2023, 1, 25, 14, 44, 35, 202, DateTimeKind.Local).AddTicks(7601) },
                    { "ba795148-6321-42e9-bd54-7f2279eb0678", "Sweden", new DateTime(2023, 1, 25, 14, 44, 35, 202, DateTimeKind.Local).AddTicks(7592) },
                    { "c2b29b41-16bf-43f1-a554-8337f29742d9", "Norway", new DateTime(2023, 1, 25, 14, 44, 35, 202, DateTimeKind.Local).AddTicks(7597) }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[,]
                {
                    { "8a9fd6a1-ac73-4811-b64a-b3a157e1bb4f", "Svenska", new DateTime(2023, 1, 25, 14, 44, 35, 202, DateTimeKind.Local).AddTicks(7487) },
                    { "8e8eec5a-341e-4054-b22a-2a6e6dd81c7a", "Engleska", new DateTime(2023, 1, 25, 14, 44, 35, 202, DateTimeKind.Local).AddTicks(7504) },
                    { "ca05c377-ab12-4651-9b55-fe175fa04c9a", "Svenska", new DateTime(2023, 1, 25, 14, 44, 35, 202, DateTimeKind.Local).AddTicks(6783) },
                    { "f884b589-bbc4-4095-9e22-46caa27aa2d2", "Persiska", new DateTime(2023, 1, 25, 14, 44, 35, 202, DateTimeKind.Local).AddTicks(7499) }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "ChefId", "CityId", "Name", "PhoneNumber", "PicPath", "Register" },
                values: new object[,]
                {
                    { "2440fb75-0dac-43a1-a569-73b2900d0dd1", 32, null, null, "Ali", "123456", " ", new DateTime(2023, 1, 25, 14, 44, 35, 202, DateTimeKind.Local).AddTicks(6856) },
                    { "625bd0e0-06e7-46b3-b8a2-bc573defe6f0", 32, null, null, "Ali 1", "123456", " ", new DateTime(2023, 1, 25, 14, 44, 35, 202, DateTimeKind.Local).AddTicks(7533) },
                    { "a9d95ee8-9c79-44fe-a63f-0d0ed98c3da3", 32, null, null, "Ali 2", "123456", " ", new DateTime(2023, 1, 25, 14, 44, 35, 202, DateTimeKind.Local).AddTicks(7538) },
                    { "c4f07fdb-e3f5-4db7-bb6f-c14d1a4bee86", 32, null, null, "Ali", "123456", " ", new DateTime(2023, 1, 25, 14, 44, 35, 202, DateTimeKind.Local).AddTicks(7527) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a3440661-8c9c-4682-9a51-862bb61d2e07", "869b55d6-1031-4d31-92b0-d5782d372109" });

            migrationBuilder.InsertData(
                table: "LanguagePerson",
                columns: new[] { "LanguagesId", "PeopleId" },
                values: new object[] { "ca05c377-ab12-4651-9b55-fe175fa04c9a", "2440fb75-0dac-43a1-a569-73b2900d0dd1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "801d6c6e-db4b-4824-afa6-a0715207b2c1");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a3440661-8c9c-4682-9a51-862bb61d2e07", "869b55d6-1031-4d31-92b0-d5782d372109" });

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "0daae921-d6aa-4f53-af71-f065f4417ac0");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "64a88fb0-4b13-4048-99f7-2f1953b09e9f");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "9260f1c2-b890-435a-aaa8-10c0852209b1");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "b3454965-35fb-446c-9a30-4c6cce683379");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "ba795148-6321-42e9-bd54-7f2279eb0678");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "c2b29b41-16bf-43f1-a554-8337f29742d9");

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { "ca05c377-ab12-4651-9b55-fe175fa04c9a", "2440fb75-0dac-43a1-a569-73b2900d0dd1" });

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "8a9fd6a1-ac73-4811-b64a-b3a157e1bb4f");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "8e8eec5a-341e-4054-b22a-2a6e6dd81c7a");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "f884b589-bbc4-4095-9e22-46caa27aa2d2");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "625bd0e0-06e7-46b3-b8a2-bc573defe6f0");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "a9d95ee8-9c79-44fe-a63f-0d0ed98c3da3");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "c4f07fdb-e3f5-4db7-bb6f-c14d1a4bee86");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3440661-8c9c-4682-9a51-862bb61d2e07");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "869b55d6-1031-4d31-92b0-d5782d372109");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "ca05c377-ab12-4651-9b55-fe175fa04c9a");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "2440fb75-0dac-43a1-a569-73b2900d0dd1");
        }
    }
}
