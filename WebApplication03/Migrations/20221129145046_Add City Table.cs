using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication03.Migrations
{
    public partial class AddCityTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "4911ecb9-6a16-466c-8a58-90ffaa4e2d09");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "6000b66f-1f36-4ea7-abf3-c515cafeed13");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "e30bd710-75d0-4012-a9f8-962737fdb150");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "5fde6d09-7948-4e0c-8a1b-6115936ab926");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "765e1868-d46c-412f-9a45-d2c55d9ac9f5");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "f5cd7eaa-aad9-45b2-8bb4-6afd996ba6c7");

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Register = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[,]
                {
                    { "24bb4d78-3963-49ee-b771-818d95b81cb5", "Engleska", new DateTime(2022, 11, 29, 15, 50, 45, 755, DateTimeKind.Local).AddTicks(3044) },
                    { "46ce05ae-acb6-4d96-a7be-fded1cfcda7b", "Persiska", new DateTime(2022, 11, 29, 15, 50, 45, 755, DateTimeKind.Local).AddTicks(3039) },
                    { "9d624898-c9b7-4e15-8b3d-13a46ad7f1ce", "Svenska", new DateTime(2022, 11, 29, 15, 50, 45, 755, DateTimeKind.Local).AddTicks(2986) }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "Name", "PhoneNumber", "Register" },
                values: new object[,]
                {
                    { "7f129d28-683c-4d7d-8688-f8838295f1f6", 32, "Ali 2", "123456", new DateTime(2022, 11, 29, 15, 50, 45, 755, DateTimeKind.Local).AddTicks(3164) },
                    { "7f4e7e94-46db-4d34-8c4d-cd994c19bdf9", 32, "Ali", "123456", new DateTime(2022, 11, 29, 15, 50, 45, 755, DateTimeKind.Local).AddTicks(3155) },
                    { "efd5ef12-1261-44ae-aba2-f945e097c056", 32, "Ali 1", "123456", new DateTime(2022, 11, 29, 15, 50, 45, 755, DateTimeKind.Local).AddTicks(3160) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "24bb4d78-3963-49ee-b771-818d95b81cb5");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "46ce05ae-acb6-4d96-a7be-fded1cfcda7b");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "9d624898-c9b7-4e15-8b3d-13a46ad7f1ce");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "7f129d28-683c-4d7d-8688-f8838295f1f6");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "7f4e7e94-46db-4d34-8c4d-cd994c19bdf9");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "efd5ef12-1261-44ae-aba2-f945e097c056");

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[,]
                {
                    { "4911ecb9-6a16-466c-8a58-90ffaa4e2d09", "Svenska", new DateTime(2022, 11, 29, 15, 46, 10, 981, DateTimeKind.Local).AddTicks(2104) },
                    { "6000b66f-1f36-4ea7-abf3-c515cafeed13", "Engleska", new DateTime(2022, 11, 29, 15, 46, 10, 981, DateTimeKind.Local).AddTicks(2186) },
                    { "e30bd710-75d0-4012-a9f8-962737fdb150", "Persiska", new DateTime(2022, 11, 29, 15, 46, 10, 981, DateTimeKind.Local).AddTicks(2143) }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "Name", "PhoneNumber", "Register" },
                values: new object[,]
                {
                    { "5fde6d09-7948-4e0c-8a1b-6115936ab926", 32, "Ali", "123456", new DateTime(2022, 11, 29, 15, 46, 10, 981, DateTimeKind.Local).AddTicks(2291) },
                    { "765e1868-d46c-412f-9a45-d2c55d9ac9f5", 32, "Ali 2", "123456", new DateTime(2022, 11, 29, 15, 46, 10, 981, DateTimeKind.Local).AddTicks(2300) },
                    { "f5cd7eaa-aad9-45b2-8bb4-6afd996ba6c7", 32, "Ali 1", "123456", new DateTime(2022, 11, 29, 15, 46, 10, 981, DateTimeKind.Local).AddTicks(2296) }
                });
        }
    }
}
