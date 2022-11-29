using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication03.Migrations
{
    public partial class SeededdatatoCitytable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
