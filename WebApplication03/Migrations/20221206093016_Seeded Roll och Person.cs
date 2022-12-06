using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication03.Migrations
{
    public partial class SeededRollochPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "2814a72c-7bff-49db-91d4-986eb29ba55b");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "89be939e-3d67-47e4-b35b-81aee71653df");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "f8ae0a98-e042-49f7-bcbd-c18cbf7efd70");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "3a6a79f6-a2ca-4396-bc9e-b87a2bc7685a");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "5bccfdd9-4d1b-4d74-9cd3-0e05edc1d17a");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "7ee608b6-b7b0-4c2f-847f-3d636db3f80b");

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { "006971a6-37b1-42c8-b930-03df0ef8dc25", "5d98aa9a-d128-4701-b307-d8084c2282d0" });

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "6764cbf0-10fb-4afd-a51f-324095b77613");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "6922fc85-4583-460c-8ef9-13630decd90e");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "a0ec5cce-3d17-4cde-a837-3eed86a30b9a");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "96f0d0da-0e49-4b46-8bf7-06ecf8bb4309");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "9cdd9411-8f08-4404-b795-f6273b2c6576");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "be403573-befb-4374-9cc3-5caef859ec6c");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "006971a6-37b1-42c8-b930-03df0ef8dc25");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "5d98aa9a-d128-4701-b307-d8084c2282d0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2e6a72cc-bde5-43c1-8b1c-cc15c5fc9c87", "5789c979-0e02-4a06-9f34-e0b623339cbc", "Admin", "ADMIN" },
                    { "ccbe6d77-4278-4923-ab05-d39d1253cc43", "ef6be23b-1abd-40c6-8de6-80dc45dd22f7", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "EfterName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Register", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "523eaa95-fa56-48f8-832e-0857fa68d910", 0, 0, "0047c43c-5663-4fd1-8c9f-414201979585", "Adminson", "admin@admin.com", false, false, null, "Admin", "ADMIN@ADMIN.COM", "ADMIN1@ADMIN.COM", "AQAAAAEAACcQAAAAEL8sWjQvZWGdRcMgkmWsrOOeHUMMMag4bL0EtPWsc0gaZYXrQhzCwhQw/HxOdjveKw==", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dc982748-e92c-4298-ae94-232198abe103", false, "admin1@admin.com" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "Name", "PostNumber", "Register" },
                values: new object[,]
                {
                    { "1a80182f-3ada-4153-9506-d0aebe277304", null, "GBG", "415 52", new DateTime(2022, 12, 6, 10, 30, 16, 38, DateTimeKind.Local).AddTicks(9612) },
                    { "5d637e48-459a-4473-a2f7-4abeb9479918", null, "Mörsil", "415 44", new DateTime(2022, 12, 6, 10, 30, 16, 38, DateTimeKind.Local).AddTicks(9624) },
                    { "8ae4970a-9ba0-45d6-b86a-f0614f4f1175", null, "Järpen", "415 55", new DateTime(2022, 12, 6, 10, 30, 16, 38, DateTimeKind.Local).AddTicks(9619) }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[,]
                {
                    { "38d510ec-87a0-4e55-8a41-f92460b7ed3f", "Danmarc", new DateTime(2022, 12, 6, 10, 30, 16, 38, DateTimeKind.Local).AddTicks(9666) },
                    { "3be19c96-d6a9-4d59-b2f6-a0daa1dfa8c5", "Norway", new DateTime(2022, 12, 6, 10, 30, 16, 38, DateTimeKind.Local).AddTicks(9662) },
                    { "d802dc3f-3a04-487a-bd88-f741bf9e9316", "Sweden", new DateTime(2022, 12, 6, 10, 30, 16, 38, DateTimeKind.Local).AddTicks(9653) }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[,]
                {
                    { "17a57c38-3c3d-4f2e-a867-989a3846c50f", "Engleska", new DateTime(2022, 12, 6, 10, 30, 16, 38, DateTimeKind.Local).AddTicks(9535) },
                    { "9b02ecc2-50d4-42d3-a791-956267c20280", "Persiska", new DateTime(2022, 12, 6, 10, 30, 16, 38, DateTimeKind.Local).AddTicks(9513) },
                    { "d5196612-f8aa-40d2-b63f-848f2784c545", "Svenska", new DateTime(2022, 12, 6, 10, 30, 16, 38, DateTimeKind.Local).AddTicks(8471) },
                    { "d9ac44e0-41ef-43cd-a65d-9f690c15bd3a", "Svenska", new DateTime(2022, 12, 6, 10, 30, 16, 38, DateTimeKind.Local).AddTicks(9500) }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "CityId", "Name", "PhoneNumber", "Register" },
                values: new object[,]
                {
                    { "8acac708-9de3-4c4f-9d4e-84078cb75cc7", 32, null, "Ali", "123456", new DateTime(2022, 12, 6, 10, 30, 16, 38, DateTimeKind.Local).AddTicks(8562) },
                    { "ab1d5607-9045-448f-808a-84e0ca1465f1", 32, null, "Ali 1", "123456", new DateTime(2022, 12, 6, 10, 30, 16, 38, DateTimeKind.Local).AddTicks(9575) },
                    { "dfda4694-efaa-4698-9cdd-8847156ea371", 32, null, "Ali", "123456", new DateTime(2022, 12, 6, 10, 30, 16, 38, DateTimeKind.Local).AddTicks(9563) },
                    { "fa0e8a8b-1b25-4aab-824c-2f2c8a209c73", 32, null, "Ali 2", "123456", new DateTime(2022, 12, 6, 10, 30, 16, 38, DateTimeKind.Local).AddTicks(9580) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2e6a72cc-bde5-43c1-8b1c-cc15c5fc9c87", "523eaa95-fa56-48f8-832e-0857fa68d910" });

            migrationBuilder.InsertData(
                table: "LanguagePerson",
                columns: new[] { "LanguagesId", "PeopleId" },
                values: new object[] { "d5196612-f8aa-40d2-b63f-848f2784c545", "8acac708-9de3-4c4f-9d4e-84078cb75cc7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ccbe6d77-4278-4923-ab05-d39d1253cc43");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2e6a72cc-bde5-43c1-8b1c-cc15c5fc9c87", "523eaa95-fa56-48f8-832e-0857fa68d910" });

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "1a80182f-3ada-4153-9506-d0aebe277304");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "5d637e48-459a-4473-a2f7-4abeb9479918");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "8ae4970a-9ba0-45d6-b86a-f0614f4f1175");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "38d510ec-87a0-4e55-8a41-f92460b7ed3f");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "3be19c96-d6a9-4d59-b2f6-a0daa1dfa8c5");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "d802dc3f-3a04-487a-bd88-f741bf9e9316");

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { "d5196612-f8aa-40d2-b63f-848f2784c545", "8acac708-9de3-4c4f-9d4e-84078cb75cc7" });

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "17a57c38-3c3d-4f2e-a867-989a3846c50f");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "9b02ecc2-50d4-42d3-a791-956267c20280");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "d9ac44e0-41ef-43cd-a65d-9f690c15bd3a");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "ab1d5607-9045-448f-808a-84e0ca1465f1");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "dfda4694-efaa-4698-9cdd-8847156ea371");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "fa0e8a8b-1b25-4aab-824c-2f2c8a209c73");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e6a72cc-bde5-43c1-8b1c-cc15c5fc9c87");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "523eaa95-fa56-48f8-832e-0857fa68d910");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "d5196612-f8aa-40d2-b63f-848f2784c545");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "8acac708-9de3-4c4f-9d4e-84078cb75cc7");

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "Name", "PostNumber", "Register" },
                values: new object[,]
                {
                    { "2814a72c-7bff-49db-91d4-986eb29ba55b", null, "Mörsil", "415 44", new DateTime(2022, 12, 6, 9, 53, 44, 493, DateTimeKind.Local).AddTicks(9667) },
                    { "89be939e-3d67-47e4-b35b-81aee71653df", null, "GBG", "415 52", new DateTime(2022, 12, 6, 9, 53, 44, 493, DateTimeKind.Local).AddTicks(9657) },
                    { "f8ae0a98-e042-49f7-bcbd-c18cbf7efd70", null, "Järpen", "415 55", new DateTime(2022, 12, 6, 9, 53, 44, 493, DateTimeKind.Local).AddTicks(9663) }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[,]
                {
                    { "3a6a79f6-a2ca-4396-bc9e-b87a2bc7685a", "Danmarc", new DateTime(2022, 12, 6, 9, 53, 44, 493, DateTimeKind.Local).AddTicks(9703) },
                    { "5bccfdd9-4d1b-4d74-9cd3-0e05edc1d17a", "Norway", new DateTime(2022, 12, 6, 9, 53, 44, 493, DateTimeKind.Local).AddTicks(9699) },
                    { "7ee608b6-b7b0-4c2f-847f-3d636db3f80b", "Sweden", new DateTime(2022, 12, 6, 9, 53, 44, 493, DateTimeKind.Local).AddTicks(9694) }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[,]
                {
                    { "006971a6-37b1-42c8-b930-03df0ef8dc25", "Svenska", new DateTime(2022, 12, 6, 9, 53, 44, 493, DateTimeKind.Local).AddTicks(8632) },
                    { "6764cbf0-10fb-4afd-a51f-324095b77613", "Engleska", new DateTime(2022, 12, 6, 9, 53, 44, 493, DateTimeKind.Local).AddTicks(9591) },
                    { "6922fc85-4583-460c-8ef9-13630decd90e", "Svenska", new DateTime(2022, 12, 6, 9, 53, 44, 493, DateTimeKind.Local).AddTicks(9575) },
                    { "a0ec5cce-3d17-4cde-a837-3eed86a30b9a", "Persiska", new DateTime(2022, 12, 6, 9, 53, 44, 493, DateTimeKind.Local).AddTicks(9586) }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "CityId", "Name", "PhoneNumber", "Register" },
                values: new object[,]
                {
                    { "5d98aa9a-d128-4701-b307-d8084c2282d0", 32, null, "Ali", "123456", new DateTime(2022, 12, 6, 9, 53, 44, 493, DateTimeKind.Local).AddTicks(8697) },
                    { "96f0d0da-0e49-4b46-8bf7-06ecf8bb4309", 32, null, "Ali", "123456", new DateTime(2022, 12, 6, 9, 53, 44, 493, DateTimeKind.Local).AddTicks(9608) },
                    { "9cdd9411-8f08-4404-b795-f6273b2c6576", 32, null, "Ali 1", "123456", new DateTime(2022, 12, 6, 9, 53, 44, 493, DateTimeKind.Local).AddTicks(9625) },
                    { "be403573-befb-4374-9cc3-5caef859ec6c", 32, null, "Ali 2", "123456", new DateTime(2022, 12, 6, 9, 53, 44, 493, DateTimeKind.Local).AddTicks(9636) }
                });

            migrationBuilder.InsertData(
                table: "LanguagePerson",
                columns: new[] { "LanguagesId", "PeopleId" },
                values: new object[] { "006971a6-37b1-42c8-b930-03df0ef8dc25", "5d98aa9a-d128-4701-b307-d8084c2282d0" });
        }
    }
}
