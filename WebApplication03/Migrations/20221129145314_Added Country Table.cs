using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication03.Migrations
{
    public partial class AddedCountryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "3c92a08e-ba6d-42fa-9499-ddfabd9e2c18");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "a7994c15-3164-4358-958d-6442c1539d2d");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "aaa3dbdf-99ef-43a3-8caa-0a9b3dfab3cf");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2159d94e-8019-45f7-a670-31444f58f4f9");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "7a749e68-a927-4a45-b37c-aceafb62c9b3");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "a2832291-a465-48f3-9253-0557178cdbae");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "1593d272-fe62-492a-975b-70f682a9f754");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "a9312451-e3f4-48c5-8fff-708564a5e52e");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "deec01f3-b68c-4711-9644-3e04a8cfdf12");

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Register = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

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
                    { "3c92a08e-ba6d-42fa-9499-ddfabd9e2c18", "Järpen", "415 55", new DateTime(2022, 11, 29, 15, 51, 43, 716, DateTimeKind.Local).AddTicks(5674) },
                    { "a7994c15-3164-4358-958d-6442c1539d2d", "Mörsil", "415 44", new DateTime(2022, 11, 29, 15, 51, 43, 716, DateTimeKind.Local).AddTicks(5678) },
                    { "aaa3dbdf-99ef-43a3-8caa-0a9b3dfab3cf", "GBG", "415 52", new DateTime(2022, 11, 29, 15, 51, 43, 716, DateTimeKind.Local).AddTicks(5669) }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[,]
                {
                    { "2159d94e-8019-45f7-a670-31444f58f4f9", "Persiska", new DateTime(2022, 11, 29, 15, 51, 43, 716, DateTimeKind.Local).AddTicks(5482) },
                    { "7a749e68-a927-4a45-b37c-aceafb62c9b3", "Engleska", new DateTime(2022, 11, 29, 15, 51, 43, 716, DateTimeKind.Local).AddTicks(5486) },
                    { "a2832291-a465-48f3-9253-0557178cdbae", "Svenska", new DateTime(2022, 11, 29, 15, 51, 43, 716, DateTimeKind.Local).AddTicks(5447) }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "Name", "PhoneNumber", "Register" },
                values: new object[,]
                {
                    { "1593d272-fe62-492a-975b-70f682a9f754", 32, "Ali", "123456", new DateTime(2022, 11, 29, 15, 51, 43, 716, DateTimeKind.Local).AddTicks(5597) },
                    { "a9312451-e3f4-48c5-8fff-708564a5e52e", 32, "Ali 1", "123456", new DateTime(2022, 11, 29, 15, 51, 43, 716, DateTimeKind.Local).AddTicks(5603) },
                    { "deec01f3-b68c-4711-9644-3e04a8cfdf12", 32, "Ali 2", "123456", new DateTime(2022, 11, 29, 15, 51, 43, 716, DateTimeKind.Local).AddTicks(5648) }
                });
        }
    }
}
