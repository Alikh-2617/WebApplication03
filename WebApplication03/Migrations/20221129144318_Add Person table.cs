using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication03.Migrations
{
    public partial class AddPersontable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Register = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");

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
    }
}
