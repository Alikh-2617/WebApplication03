using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication03.Migrations
{
    public partial class SeededDatatoLanguageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[] { "4c48c2c8-cb47-426a-ae73-6490a5699cfa", "Persiska", new DateTime(2022, 11, 29, 15, 41, 26, 220, DateTimeKind.Local).AddTicks(1315) });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[] { "a40b55c9-a7ec-4b53-b68f-f5433a67f70d", "Engleska", new DateTime(2022, 11, 29, 15, 41, 26, 220, DateTimeKind.Local).AddTicks(1320) });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[] { "e7725861-3177-44ac-bbee-e057723706a4", "Svenska", new DateTime(2022, 11, 29, 15, 41, 26, 220, DateTimeKind.Local).AddTicks(1276) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "4c48c2c8-cb47-426a-ae73-6490a5699cfa");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "a40b55c9-a7ec-4b53-b68f-f5433a67f70d");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "e7725861-3177-44ac-bbee-e057723706a4");
        }
    }
}
