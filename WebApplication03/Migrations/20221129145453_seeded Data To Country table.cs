using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication03.Migrations
{
    public partial class seededDataToCountrytable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "b16b965a-2f0a-47cc-bd71-deed99c4055a");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "c7cae29b-3a0e-4ae2-87ba-dcfaa1d96168");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "f4f6b504-6d93-4d41-8955-7af9d9e1646f");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "28be7bb6-6da0-497d-854d-6c3f485aa8b4");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "307e2b0c-398d-40e0-bed5-378cdc553b85");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "714e9b9f-9d58-45d3-9080-2d746d93aae7");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "4763a4b5-b215-499b-8c19-9e0464fc2a24");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "4ba097b0-aa62-41a6-99a8-fb5c2905e465");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "a943e115-ce5a-4ad5-9661-253bf4981192");

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name", "PostNumber", "Register" },
                values: new object[,]
                {
                    { "08190b49-2610-416e-9209-14bffdc4cb73", "Järpen", "415 55", new DateTime(2022, 11, 29, 15, 54, 53, 601, DateTimeKind.Local).AddTicks(9223) },
                    { "b9c2017b-ac5d-466c-8bd5-ebb4f5b6397d", "Mörsil", "415 44", new DateTime(2022, 11, 29, 15, 54, 53, 601, DateTimeKind.Local).AddTicks(9227) },
                    { "bc8c6418-8b50-4bac-a230-2c238ca9b10f", "GBG", "415 52", new DateTime(2022, 11, 29, 15, 54, 53, 601, DateTimeKind.Local).AddTicks(9218) }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[,]
                {
                    { "05b559f5-38a9-4651-a285-5034e6466996", "Norway", new DateTime(2022, 11, 29, 15, 54, 53, 601, DateTimeKind.Local).AddTicks(9254) },
                    { "3b5cf351-a249-4091-aa02-075d3250d962", "Danmarc", new DateTime(2022, 11, 29, 15, 54, 53, 601, DateTimeKind.Local).AddTicks(9258) },
                    { "dfa952cd-d673-4da8-8cf7-a980e755e6d5", "Sweden", new DateTime(2022, 11, 29, 15, 54, 53, 601, DateTimeKind.Local).AddTicks(9250) }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[,]
                {
                    { "47d9afec-aabe-41f8-9c3e-9e6f1b64b167", "Svenska", new DateTime(2022, 11, 29, 15, 54, 53, 601, DateTimeKind.Local).AddTicks(8922) },
                    { "52778a6c-e716-495a-8ab4-411d7e5cfc38", "Persiska", new DateTime(2022, 11, 29, 15, 54, 53, 601, DateTimeKind.Local).AddTicks(8970) },
                    { "6e733ca0-ac43-45a0-81ca-16dbf2d29955", "Engleska", new DateTime(2022, 11, 29, 15, 54, 53, 601, DateTimeKind.Local).AddTicks(8974) }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "Name", "PhoneNumber", "Register" },
                values: new object[,]
                {
                    { "37f6a1f7-7fa0-4a05-b19e-b2d27a8cb0ac", 32, "Ali 1", "123456", new DateTime(2022, 11, 29, 15, 54, 53, 601, DateTimeKind.Local).AddTicks(9180) },
                    { "42c9438f-4e95-4bea-90a6-00f94596abcf", 32, "Ali 2", "123456", new DateTime(2022, 11, 29, 15, 54, 53, 601, DateTimeKind.Local).AddTicks(9184) },
                    { "6e34a6ea-d8bb-4a0e-8230-b71ebbf53f04", 32, "Ali", "123456", new DateTime(2022, 11, 29, 15, 54, 53, 601, DateTimeKind.Local).AddTicks(9174) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "08190b49-2610-416e-9209-14bffdc4cb73");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "b9c2017b-ac5d-466c-8bd5-ebb4f5b6397d");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "bc8c6418-8b50-4bac-a230-2c238ca9b10f");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "05b559f5-38a9-4651-a285-5034e6466996");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "3b5cf351-a249-4091-aa02-075d3250d962");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "dfa952cd-d673-4da8-8cf7-a980e755e6d5");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "47d9afec-aabe-41f8-9c3e-9e6f1b64b167");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "52778a6c-e716-495a-8ab4-411d7e5cfc38");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "6e733ca0-ac43-45a0-81ca-16dbf2d29955");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "37f6a1f7-7fa0-4a05-b19e-b2d27a8cb0ac");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "42c9438f-4e95-4bea-90a6-00f94596abcf");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "6e34a6ea-d8bb-4a0e-8230-b71ebbf53f04");

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name", "PostNumber", "Register" },
                values: new object[,]
                {
                    { "b16b965a-2f0a-47cc-bd71-deed99c4055a", "GBG", "415 52", new DateTime(2022, 11, 29, 15, 53, 13, 730, DateTimeKind.Local).AddTicks(267) },
                    { "c7cae29b-3a0e-4ae2-87ba-dcfaa1d96168", "Mörsil", "415 44", new DateTime(2022, 11, 29, 15, 53, 13, 730, DateTimeKind.Local).AddTicks(276) },
                    { "f4f6b504-6d93-4d41-8955-7af9d9e1646f", "Järpen", "415 55", new DateTime(2022, 11, 29, 15, 53, 13, 730, DateTimeKind.Local).AddTicks(272) }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[,]
                {
                    { "28be7bb6-6da0-497d-854d-6c3f485aa8b4", "Svenska", new DateTime(2022, 11, 29, 15, 53, 13, 730, DateTimeKind.Local).AddTicks(60) },
                    { "307e2b0c-398d-40e0-bed5-378cdc553b85", "Persiska", new DateTime(2022, 11, 29, 15, 53, 13, 730, DateTimeKind.Local).AddTicks(98) },
                    { "714e9b9f-9d58-45d3-9080-2d746d93aae7", "Engleska", new DateTime(2022, 11, 29, 15, 53, 13, 730, DateTimeKind.Local).AddTicks(106) }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "Name", "PhoneNumber", "Register" },
                values: new object[,]
                {
                    { "4763a4b5-b215-499b-8c19-9e0464fc2a24", 32, "Ali 1", "123456", new DateTime(2022, 11, 29, 15, 53, 13, 730, DateTimeKind.Local).AddTicks(223) },
                    { "4ba097b0-aa62-41a6-99a8-fb5c2905e465", 32, "Ali 2", "123456", new DateTime(2022, 11, 29, 15, 53, 13, 730, DateTimeKind.Local).AddTicks(241) },
                    { "a943e115-ce5a-4ad5-9661-253bf4981192", 32, "Ali", "123456", new DateTime(2022, 11, 29, 15, 53, 13, 730, DateTimeKind.Local).AddTicks(218) }
                });
        }
    }
}
