using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication03.Migrations
{
    public partial class SeededmellanTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "31cdde65-b584-47f9-9ff6-2936c4f00f84");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "6c44cc8f-f927-4678-84e5-7ffec3a67cb4");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "e854a2bd-9f53-4a43-baf6-6a185d2f0461");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "a3bafd45-e62f-4ba1-8990-86569bc34410");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "c929ced4-9aae-4fe6-b9ca-418a2260fca6");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "e71f4146-e8ca-4d50-b953-d07ce1535e05");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "8f48049f-965f-4721-ad1c-3bb589227750");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "bf6fd29b-78f5-4ade-82de-7a75abd2ca45");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "c24b7ddb-f532-4037-8c0c-4a125c97f759");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "547aa015-6131-403f-87bd-a8a2e7222afa");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "6d99b3e9-8aaa-4f4e-9138-c3cc894d5446");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "81e3f262-0c65-4f18-9e17-ec937cb13a84");

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name", "PostNumber", "Register" },
                values: new object[,]
                {
                    { "55c63a23-fb3e-4895-8e24-844458860413", "GBG", "415 52", new DateTime(2022, 11, 29, 16, 1, 34, 339, DateTimeKind.Local).AddTicks(973) },
                    { "78bd3ee4-26f3-4a74-9656-3747e0ea3294", "Järpen", "415 55", new DateTime(2022, 11, 29, 16, 1, 34, 339, DateTimeKind.Local).AddTicks(978) },
                    { "c25a047b-112f-457f-b1c3-1ca3a9f25633", "Mörsil", "415 44", new DateTime(2022, 11, 29, 16, 1, 34, 339, DateTimeKind.Local).AddTicks(982) }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[,]
                {
                    { "7f945feb-2238-4eac-bffd-8f07e833bf5f", "Sweden", new DateTime(2022, 11, 29, 16, 1, 34, 339, DateTimeKind.Local).AddTicks(1004) },
                    { "9f89e6b5-22f9-4ab1-b1ff-75c43c873a81", "Norway", new DateTime(2022, 11, 29, 16, 1, 34, 339, DateTimeKind.Local).AddTicks(1009) },
                    { "cc108784-47ff-47f8-81ae-e00033c3a4b5", "Danmarc", new DateTime(2022, 11, 29, 16, 1, 34, 339, DateTimeKind.Local).AddTicks(1012) }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[,]
                {
                    { "269777c7-9298-4d9a-be0c-eb61a8752b1a", "Svenska", new DateTime(2022, 11, 29, 16, 1, 34, 339, DateTimeKind.Local).AddTicks(904) },
                    { "5b577863-95fb-4cd8-b2e7-d0184fdc8fa2", "Svenska", new DateTime(2022, 11, 29, 16, 1, 34, 339, DateTimeKind.Local).AddTicks(167) },
                    { "ad712968-7145-4c87-be43-e30e75d97e41", "Engleska", new DateTime(2022, 11, 29, 16, 1, 34, 339, DateTimeKind.Local).AddTicks(930) },
                    { "c019a187-82ac-4aba-a744-301588257250", "Persiska", new DateTime(2022, 11, 29, 16, 1, 34, 339, DateTimeKind.Local).AddTicks(926) }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "Name", "PhoneNumber", "Register" },
                values: new object[,]
                {
                    { "075138be-b34f-4199-972b-7e8a3b31fddd", 32, "Ali", "123456", new DateTime(2022, 11, 29, 16, 1, 34, 339, DateTimeKind.Local).AddTicks(946) },
                    { "49a35039-7fab-4dca-a8a1-dde310fcf906", 32, "Ali 2", "123456", new DateTime(2022, 11, 29, 16, 1, 34, 339, DateTimeKind.Local).AddTicks(955) },
                    { "ba2656cd-c18f-45df-9932-7711b34da98b", 32, "Ali", "123456", new DateTime(2022, 11, 29, 16, 1, 34, 339, DateTimeKind.Local).AddTicks(227) },
                    { "d55437b6-b13f-45ab-8596-dba93d6756d8", 32, "Ali 1", "123456", new DateTime(2022, 11, 29, 16, 1, 34, 339, DateTimeKind.Local).AddTicks(951) }
                });

            migrationBuilder.InsertData(
                table: "LanguagePerson",
                columns: new[] { "LanguagesId", "PeopleId" },
                values: new object[] { "5b577863-95fb-4cd8-b2e7-d0184fdc8fa2", "ba2656cd-c18f-45df-9932-7711b34da98b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "55c63a23-fb3e-4895-8e24-844458860413");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "78bd3ee4-26f3-4a74-9656-3747e0ea3294");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "c25a047b-112f-457f-b1c3-1ca3a9f25633");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "7f945feb-2238-4eac-bffd-8f07e833bf5f");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "9f89e6b5-22f9-4ab1-b1ff-75c43c873a81");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "cc108784-47ff-47f8-81ae-e00033c3a4b5");

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { "5b577863-95fb-4cd8-b2e7-d0184fdc8fa2", "ba2656cd-c18f-45df-9932-7711b34da98b" });

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "269777c7-9298-4d9a-be0c-eb61a8752b1a");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "ad712968-7145-4c87-be43-e30e75d97e41");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "c019a187-82ac-4aba-a744-301588257250");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "075138be-b34f-4199-972b-7e8a3b31fddd");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "49a35039-7fab-4dca-a8a1-dde310fcf906");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "d55437b6-b13f-45ab-8596-dba93d6756d8");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "5b577863-95fb-4cd8-b2e7-d0184fdc8fa2");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "ba2656cd-c18f-45df-9932-7711b34da98b");

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name", "PostNumber", "Register" },
                values: new object[,]
                {
                    { "31cdde65-b584-47f9-9ff6-2936c4f00f84", "GBG", "415 52", new DateTime(2022, 11, 29, 15, 59, 55, 455, DateTimeKind.Local).AddTicks(9109) },
                    { "6c44cc8f-f927-4678-84e5-7ffec3a67cb4", "Mörsil", "415 44", new DateTime(2022, 11, 29, 15, 59, 55, 455, DateTimeKind.Local).AddTicks(9118) },
                    { "e854a2bd-9f53-4a43-baf6-6a185d2f0461", "Järpen", "415 55", new DateTime(2022, 11, 29, 15, 59, 55, 455, DateTimeKind.Local).AddTicks(9114) }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[,]
                {
                    { "a3bafd45-e62f-4ba1-8990-86569bc34410", "Sweden", new DateTime(2022, 11, 29, 15, 59, 55, 455, DateTimeKind.Local).AddTicks(9137) },
                    { "c929ced4-9aae-4fe6-b9ca-418a2260fca6", "Norway", new DateTime(2022, 11, 29, 15, 59, 55, 455, DateTimeKind.Local).AddTicks(9142) },
                    { "e71f4146-e8ca-4d50-b953-d07ce1535e05", "Danmarc", new DateTime(2022, 11, 29, 15, 59, 55, 455, DateTimeKind.Local).AddTicks(9146) }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[,]
                {
                    { "8f48049f-965f-4721-ad1c-3bb589227750", "Engleska", new DateTime(2022, 11, 29, 15, 59, 55, 455, DateTimeKind.Local).AddTicks(8927) },
                    { "bf6fd29b-78f5-4ade-82de-7a75abd2ca45", "Svenska", new DateTime(2022, 11, 29, 15, 59, 55, 455, DateTimeKind.Local).AddTicks(8889) },
                    { "c24b7ddb-f532-4037-8c0c-4a125c97f759", "Persiska", new DateTime(2022, 11, 29, 15, 59, 55, 455, DateTimeKind.Local).AddTicks(8923) }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "Name", "PhoneNumber", "Register" },
                values: new object[,]
                {
                    { "547aa015-6131-403f-87bd-a8a2e7222afa", 32, "Ali 1", "123456", new DateTime(2022, 11, 29, 15, 59, 55, 455, DateTimeKind.Local).AddTicks(9086) },
                    { "6d99b3e9-8aaa-4f4e-9138-c3cc894d5446", 32, "Ali", "123456", new DateTime(2022, 11, 29, 15, 59, 55, 455, DateTimeKind.Local).AddTicks(9068) },
                    { "81e3f262-0c65-4f18-9e17-ec937cb13a84", 32, "Ali 2", "123456", new DateTime(2022, 11, 29, 15, 59, 55, 455, DateTimeKind.Local).AddTicks(9089) }
                });
        }
    }
}
