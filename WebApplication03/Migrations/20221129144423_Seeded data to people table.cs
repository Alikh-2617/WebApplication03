using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication03.Migrations
{
    public partial class Seededdatatopeopletable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "13760188-e240-48f4-962f-6cfd9b59c6ea");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "55ab194c-eafb-461d-a47d-eb61a9f7031c");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "f6bc00f3-80a6-4a2f-9c11-f8ab292b1899");

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[,]
                {
                    { "63dfe312-d9a4-41f7-bf0f-9dafd4a149ea", "Engleska", new DateTime(2022, 11, 29, 15, 44, 23, 163, DateTimeKind.Local).AddTicks(1121) },
                    { "a13dfdf8-41ef-4e69-9acb-fe038248c2ef", "Persiska", new DateTime(2022, 11, 29, 15, 44, 23, 163, DateTimeKind.Local).AddTicks(1116) },
                    { "cd84dc9f-f763-4fae-ac42-c349668531e1", "Svenska", new DateTime(2022, 11, 29, 15, 44, 23, 163, DateTimeKind.Local).AddTicks(1080) }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "Name", "PhoneNumber", "Register" },
                values: new object[,]
                {
                    { "1a6f95a7-aa50-4c12-aa4c-e3f5dee004e7", 32, "Ali 2", "123456", new DateTime(2022, 11, 29, 15, 44, 23, 163, DateTimeKind.Local).AddTicks(1249) },
                    { "56097b99-b519-4f28-a58a-941abc2015fe", 32, "Ali 1", "123456", new DateTime(2022, 11, 29, 15, 44, 23, 163, DateTimeKind.Local).AddTicks(1234) },
                    { "f0011acb-ad28-4a01-9f96-79deed43e9f0", 32, "Ali", "123456", new DateTime(2022, 11, 29, 15, 44, 23, 163, DateTimeKind.Local).AddTicks(1228) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "63dfe312-d9a4-41f7-bf0f-9dafd4a149ea");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "a13dfdf8-41ef-4e69-9acb-fe038248c2ef");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "cd84dc9f-f763-4fae-ac42-c349668531e1");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "1a6f95a7-aa50-4c12-aa4c-e3f5dee004e7");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "56097b99-b519-4f28-a58a-941abc2015fe");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "f0011acb-ad28-4a01-9f96-79deed43e9f0");

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[] { "13760188-e240-48f4-962f-6cfd9b59c6ea", "Persiska", new DateTime(2022, 11, 29, 15, 43, 18, 179, DateTimeKind.Local).AddTicks(2516) });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[] { "55ab194c-eafb-461d-a47d-eb61a9f7031c", "Svenska", new DateTime(2022, 11, 29, 15, 43, 18, 179, DateTimeKind.Local).AddTicks(2480) });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[] { "f6bc00f3-80a6-4a2f-9c11-f8ab292b1899", "Engleska", new DateTime(2022, 11, 29, 15, 43, 18, 179, DateTimeKind.Local).AddTicks(2521) });
        }
    }
}
