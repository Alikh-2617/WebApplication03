using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication03.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "CityCountry",
                columns: table => new
                {
                    CitiesId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CountriesId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityCountry", x => new { x.CitiesId, x.CountriesId });
                    table.ForeignKey(
                        name: "FK_CityCountry_Cities_CitiesId",
                        column: x => x.CitiesId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CityCountry_Countries_CountriesId",
                        column: x => x.CountriesId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CityCountry_CountriesId",
                table: "CityCountry",
                column: "CountriesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CityCountry");

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
    }
}
