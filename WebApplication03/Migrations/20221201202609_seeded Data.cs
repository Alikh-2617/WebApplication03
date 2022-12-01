using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication03.Migrations
{
    public partial class seededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "Name", "PostNumber", "Register" },
                values: new object[,]
                {
                    { "552443b2-6831-4720-8023-43f843fa1d9f", null, "Järpen", "415 55", new DateTime(2022, 12, 1, 21, 26, 9, 653, DateTimeKind.Local).AddTicks(9994) },
                    { "b4b589b9-e05b-41e7-a706-1cb2751d0beb", null, "Mörsil", "415 44", new DateTime(2022, 12, 1, 21, 26, 9, 653, DateTimeKind.Local).AddTicks(9998) },
                    { "e27cbb32-ff29-4884-a94c-8b7b60bc2b2f", null, "GBG", "415 52", new DateTime(2022, 12, 1, 21, 26, 9, 653, DateTimeKind.Local).AddTicks(9989) }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[,]
                {
                    { "0b6fdd2f-e148-4b35-aa63-5b863359821a", "Sweden", new DateTime(2022, 12, 1, 21, 26, 9, 654, DateTimeKind.Local).AddTicks(20) },
                    { "5c97ca1e-d39a-4958-9d88-c37f62bbff81", "Norway", new DateTime(2022, 12, 1, 21, 26, 9, 654, DateTimeKind.Local).AddTicks(27) },
                    { "aaeceb46-e21a-4904-aa61-e5f802ca0890", "Danmarc", new DateTime(2022, 12, 1, 21, 26, 9, 654, DateTimeKind.Local).AddTicks(32) }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[,]
                {
                    { "883e5698-b1a8-4ea7-819f-4a5079df4949", "Engleska", new DateTime(2022, 12, 1, 21, 26, 9, 653, DateTimeKind.Local).AddTicks(9940) },
                    { "964212fe-169e-47d7-b581-dd91fd5d153b", "Persiska", new DateTime(2022, 12, 1, 21, 26, 9, 653, DateTimeKind.Local).AddTicks(9925) },
                    { "e6dbf485-c2a6-40bf-ac55-3667cafa4c39", "Svenska", new DateTime(2022, 12, 1, 21, 26, 9, 653, DateTimeKind.Local).AddTicks(9013) },
                    { "ebdc3afb-727b-4e94-a70e-d5589a810f47", "Svenska", new DateTime(2022, 12, 1, 21, 26, 9, 653, DateTimeKind.Local).AddTicks(9915) }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "CityId", "Name", "PhoneNumber", "Register" },
                values: new object[,]
                {
                    { "2163f1c3-18b9-4273-b25b-eb4b45b0fd49", 32, null, "Ali 2", "123456", new DateTime(2022, 12, 1, 21, 26, 9, 653, DateTimeKind.Local).AddTicks(9972) },
                    { "7c544e13-ff95-42bd-9d98-4fc006fda9f8", 32, null, "Ali 1", "123456", new DateTime(2022, 12, 1, 21, 26, 9, 653, DateTimeKind.Local).AddTicks(9968) },
                    { "f1cbc93c-af18-4d05-ab0e-e39fd146e32f", 32, null, "Ali", "123456", new DateTime(2022, 12, 1, 21, 26, 9, 653, DateTimeKind.Local).AddTicks(9963) },
                    { "f5522beb-c267-4461-8d7c-53e2246adc5a", 32, null, "Ali", "123456", new DateTime(2022, 12, 1, 21, 26, 9, 653, DateTimeKind.Local).AddTicks(9082) }
                });

            migrationBuilder.InsertData(
                table: "LanguagePerson",
                columns: new[] { "LanguagesId", "PeopleId" },
                values: new object[] { "e6dbf485-c2a6-40bf-ac55-3667cafa4c39", "f5522beb-c267-4461-8d7c-53e2246adc5a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "552443b2-6831-4720-8023-43f843fa1d9f");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "b4b589b9-e05b-41e7-a706-1cb2751d0beb");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "e27cbb32-ff29-4884-a94c-8b7b60bc2b2f");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "0b6fdd2f-e148-4b35-aa63-5b863359821a");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "5c97ca1e-d39a-4958-9d88-c37f62bbff81");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "aaeceb46-e21a-4904-aa61-e5f802ca0890");

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { "e6dbf485-c2a6-40bf-ac55-3667cafa4c39", "f5522beb-c267-4461-8d7c-53e2246adc5a" });

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "883e5698-b1a8-4ea7-819f-4a5079df4949");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "964212fe-169e-47d7-b581-dd91fd5d153b");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "ebdc3afb-727b-4e94-a70e-d5589a810f47");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "2163f1c3-18b9-4273-b25b-eb4b45b0fd49");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "7c544e13-ff95-42bd-9d98-4fc006fda9f8");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "f1cbc93c-af18-4d05-ab0e-e39fd146e32f");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "e6dbf485-c2a6-40bf-ac55-3667cafa4c39");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "f5522beb-c267-4461-8d7c-53e2246adc5a");
        }
    }
}
