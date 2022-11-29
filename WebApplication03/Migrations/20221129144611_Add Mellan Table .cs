using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication03.Migrations
{
    public partial class AddMellanTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "LanguagePerson",
                columns: table => new
                {
                    LanguagesId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PeopleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguagePerson", x => new { x.LanguagesId, x.PeopleId });
                    table.ForeignKey(
                        name: "FK_LanguagePerson_Languages_LanguagesId",
                        column: x => x.LanguagesId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguagePerson_People_PeopleId",
                        column: x => x.PeopleId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LanguagePerson_PeopleId",
                table: "LanguagePerson",
                column: "PeopleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LanguagePerson");

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
    }
}
