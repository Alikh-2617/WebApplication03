using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication03.Migrations
{
    public partial class AddedMellantablecountryandCity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "CountryId",
                table: "Cities",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "Name", "PostNumber", "Register" },
                values: new object[,]
                {
                    { "1d2d45a3-06f6-439b-870d-beb4014f9ac1", null, "GBG", "415 52", new DateTime(2022, 11, 29, 15, 56, 19, 375, DateTimeKind.Local).AddTicks(9728) },
                    { "21fc0b1a-09f7-44c9-8d1d-331a6452b1ed", null, "Mörsil", "415 44", new DateTime(2022, 11, 29, 15, 56, 19, 375, DateTimeKind.Local).AddTicks(9737) },
                    { "23c17856-95b3-4318-946e-4c3b60d8d2b2", null, "Järpen", "415 55", new DateTime(2022, 11, 29, 15, 56, 19, 375, DateTimeKind.Local).AddTicks(9733) }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[,]
                {
                    { "1c7ea0d7-d579-44aa-9a9b-6252bff20d05", "Danmarc", new DateTime(2022, 11, 29, 15, 56, 19, 375, DateTimeKind.Local).AddTicks(9768) },
                    { "27606428-2a0d-4045-a271-4cde453b2555", "Norway", new DateTime(2022, 11, 29, 15, 56, 19, 375, DateTimeKind.Local).AddTicks(9764) },
                    { "73b9792f-73b8-4bd9-9a9e-3efec0d09f0f", "Sweden", new DateTime(2022, 11, 29, 15, 56, 19, 375, DateTimeKind.Local).AddTicks(9759) }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[,]
                {
                    { "d815419f-22e1-4e01-8058-2f72ffae52d6", "Persiska", new DateTime(2022, 11, 29, 15, 56, 19, 375, DateTimeKind.Local).AddTicks(9460) },
                    { "f635cb16-9c0d-4d17-a13d-3d4613e2b89f", "Engleska", new DateTime(2022, 11, 29, 15, 56, 19, 375, DateTimeKind.Local).AddTicks(9465) },
                    { "fd5db384-3a4a-4c0c-9c72-c2acc3443c0c", "Svenska", new DateTime(2022, 11, 29, 15, 56, 19, 375, DateTimeKind.Local).AddTicks(9419) }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "Name", "PhoneNumber", "Register" },
                values: new object[,]
                {
                    { "37d63494-4739-4a2d-8888-37112b548dff", 32, "Ali 2", "123456", new DateTime(2022, 11, 29, 15, 56, 19, 375, DateTimeKind.Local).AddTicks(9707) },
                    { "3cf1092a-2ba7-4af4-8376-01a51fb7e5f1", 32, "Ali", "123456", new DateTime(2022, 11, 29, 15, 56, 19, 375, DateTimeKind.Local).AddTicks(9595) },
                    { "78d1df8c-87a9-497d-967d-4f9cccf6a79a", 32, "Ali 1", "123456", new DateTime(2022, 11, 29, 15, 56, 19, 375, DateTimeKind.Local).AddTicks(9601) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_Cities_CountryId",
                table: "Cities");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "1d2d45a3-06f6-439b-870d-beb4014f9ac1");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "21fc0b1a-09f7-44c9-8d1d-331a6452b1ed");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "23c17856-95b3-4318-946e-4c3b60d8d2b2");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "1c7ea0d7-d579-44aa-9a9b-6252bff20d05");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "27606428-2a0d-4045-a271-4cde453b2555");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "73b9792f-73b8-4bd9-9a9e-3efec0d09f0f");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "d815419f-22e1-4e01-8058-2f72ffae52d6");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "f635cb16-9c0d-4d17-a13d-3d4613e2b89f");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "fd5db384-3a4a-4c0c-9c72-c2acc3443c0c");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "37d63494-4739-4a2d-8888-37112b548dff");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "3cf1092a-2ba7-4af4-8376-01a51fb7e5f1");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "78d1df8c-87a9-497d-967d-4f9cccf6a79a");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Cities");

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
    }
}
