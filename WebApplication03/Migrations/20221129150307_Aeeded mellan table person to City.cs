using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication03.Migrations
{
    public partial class AeededmellantablepersontoCity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "55c63a23-fb3e-4895-8e24-844458860413");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "78bd3ee4-26f3-4a74-9656-3747e0ea3294");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "c25a047b-112f-457f-b1c3-1ca3a9f25633");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "7f945feb-2238-4eac-bffd-8f07e833bf5f");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "9f89e6b5-22f9-4ab1-b1ff-75c43c873a81");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "cc108784-47ff-47f8-81ae-e00033c3a4b5");

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { "5b577863-95fb-4cd8-b2e7-d0184fdc8fa2", "ba2656cd-c18f-45df-9932-7711b34da98b" });

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "269777c7-9298-4d9a-be0c-eb61a8752b1a");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "ad712968-7145-4c87-be43-e30e75d97e41");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "c019a187-82ac-4aba-a744-301588257250");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "075138be-b34f-4199-972b-7e8a3b31fddd");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "49a35039-7fab-4dca-a8a1-dde310fcf906");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "d55437b6-b13f-45ab-8596-dba93d6756d8");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "5b577863-95fb-4cd8-b2e7-d0184fdc8fa2");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "ba2656cd-c18f-45df-9932-7711b34da98b");

            migrationBuilder.CreateTable(
                name: "CityPerson",
                columns: table => new
                {
                    CitiesId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PeopleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityPerson", x => new { x.CitiesId, x.PeopleId });
                    table.ForeignKey(
                        name: "FK_CityPerson_Cities_CitiesId",
                        column: x => x.CitiesId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CityPerson_People_PeopleId",
                        column: x => x.PeopleId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name", "PostNumber", "Register" },
                values: new object[,]
                {
                    { "39483b94-c0b4-4d44-8659-d677154e544a", "Järpen", "415 55", new DateTime(2022, 11, 29, 16, 3, 7, 136, DateTimeKind.Local).AddTicks(1614) },
                    { "4be5ad4d-6b10-4e2c-bcb5-b1883fc28364", "GBG", "415 52", new DateTime(2022, 11, 29, 16, 3, 7, 136, DateTimeKind.Local).AddTicks(1608) },
                    { "e942d842-0228-4db8-a03a-f7bc9c6459ae", "Mörsil", "415 44", new DateTime(2022, 11, 29, 16, 3, 7, 136, DateTimeKind.Local).AddTicks(1619) }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[,]
                {
                    { "699e9f36-6d88-41ee-9e22-7f0e7bf3b320", "Sweden", new DateTime(2022, 11, 29, 16, 3, 7, 136, DateTimeKind.Local).AddTicks(1693) },
                    { "9208e40c-5896-42fd-934d-3dd6876b00fc", "Danmarc", new DateTime(2022, 11, 29, 16, 3, 7, 136, DateTimeKind.Local).AddTicks(1705) },
                    { "fc1022dd-7f8a-48c5-b4d8-ee18b4cc0228", "Norway", new DateTime(2022, 11, 29, 16, 3, 7, 136, DateTimeKind.Local).AddTicks(1701) }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[,]
                {
                    { "5eb94ff2-e70b-42bf-8235-0b68823539c6", "Engleska", new DateTime(2022, 11, 29, 16, 3, 7, 136, DateTimeKind.Local).AddTicks(1563) },
                    { "5fa3acd2-10fc-497c-9263-c8cb8e82442a", "Persiska", new DateTime(2022, 11, 29, 16, 3, 7, 136, DateTimeKind.Local).AddTicks(1547) },
                    { "6f31dec1-68ed-43eb-8879-48fefa9b300e", "Svenska", new DateTime(2022, 11, 29, 16, 3, 7, 136, DateTimeKind.Local).AddTicks(1535) },
                    { "a1fd255e-4ac9-4b59-9824-8858e8a3f2c6", "Svenska", new DateTime(2022, 11, 29, 16, 3, 7, 136, DateTimeKind.Local).AddTicks(715) }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "Name", "PhoneNumber", "Register" },
                values: new object[,]
                {
                    { "0f911629-8b2a-45e0-b992-02bf00de2501", 32, "Ali 1", "123456", new DateTime(2022, 11, 29, 16, 3, 7, 136, DateTimeKind.Local).AddTicks(1583) },
                    { "6d08ef9c-ee82-4118-9d91-1c61e2f1514a", 32, "Ali 2", "123456", new DateTime(2022, 11, 29, 16, 3, 7, 136, DateTimeKind.Local).AddTicks(1587) },
                    { "7b4e46c6-eeb9-4348-8b79-9c03e9e0d049", 32, "Ali", "123456", new DateTime(2022, 11, 29, 16, 3, 7, 136, DateTimeKind.Local).AddTicks(1579) },
                    { "9d4a7b70-b3e3-4eaa-8bef-1844cb2f427a", 32, "Ali", "123456", new DateTime(2022, 11, 29, 16, 3, 7, 136, DateTimeKind.Local).AddTicks(775) }
                });

            migrationBuilder.InsertData(
                table: "LanguagePerson",
                columns: new[] { "LanguagesId", "PeopleId" },
                values: new object[] { "a1fd255e-4ac9-4b59-9824-8858e8a3f2c6", "9d4a7b70-b3e3-4eaa-8bef-1844cb2f427a" });

            migrationBuilder.CreateIndex(
                name: "IX_CityPerson_PeopleId",
                table: "CityPerson",
                column: "PeopleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CityPerson");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "39483b94-c0b4-4d44-8659-d677154e544a");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "4be5ad4d-6b10-4e2c-bcb5-b1883fc28364");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "e942d842-0228-4db8-a03a-f7bc9c6459ae");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "699e9f36-6d88-41ee-9e22-7f0e7bf3b320");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "9208e40c-5896-42fd-934d-3dd6876b00fc");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "fc1022dd-7f8a-48c5-b4d8-ee18b4cc0228");

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { "a1fd255e-4ac9-4b59-9824-8858e8a3f2c6", "9d4a7b70-b3e3-4eaa-8bef-1844cb2f427a" });

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "5eb94ff2-e70b-42bf-8235-0b68823539c6");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "5fa3acd2-10fc-497c-9263-c8cb8e82442a");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "6f31dec1-68ed-43eb-8879-48fefa9b300e");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "0f911629-8b2a-45e0-b992-02bf00de2501");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "6d08ef9c-ee82-4118-9d91-1c61e2f1514a");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "7b4e46c6-eeb9-4348-8b79-9c03e9e0d049");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "a1fd255e-4ac9-4b59-9824-8858e8a3f2c6");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "9d4a7b70-b3e3-4eaa-8bef-1844cb2f427a");

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name", "PostNumber", "Register" },
                values: new object[,]
                {
                    { "55c63a23-fb3e-4895-8e24-844458860413", "GBG", "415 52", new DateTime(2022, 11, 29, 16, 1, 34, 339, DateTimeKind.Local).AddTicks(973) },
                    { "78bd3ee4-26f3-4a74-9656-3747e0ea3294", "Järpen", "415 55", new DateTime(2022, 11, 29, 16, 1, 34, 339, DateTimeKind.Local).AddTicks(978) },
                    { "c25a047b-112f-457f-b1c3-1ca3a9f25633", "Mörsil", "415 44", new DateTime(2022, 11, 29, 16, 1, 34, 339, DateTimeKind.Local).AddTicks(982) }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[,]
                {
                    { "7f945feb-2238-4eac-bffd-8f07e833bf5f", "Sweden", new DateTime(2022, 11, 29, 16, 1, 34, 339, DateTimeKind.Local).AddTicks(1004) },
                    { "9f89e6b5-22f9-4ab1-b1ff-75c43c873a81", "Norway", new DateTime(2022, 11, 29, 16, 1, 34, 339, DateTimeKind.Local).AddTicks(1009) },
                    { "cc108784-47ff-47f8-81ae-e00033c3a4b5", "Danmarc", new DateTime(2022, 11, 29, 16, 1, 34, 339, DateTimeKind.Local).AddTicks(1012) }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[,]
                {
                    { "269777c7-9298-4d9a-be0c-eb61a8752b1a", "Svenska", new DateTime(2022, 11, 29, 16, 1, 34, 339, DateTimeKind.Local).AddTicks(904) },
                    { "5b577863-95fb-4cd8-b2e7-d0184fdc8fa2", "Svenska", new DateTime(2022, 11, 29, 16, 1, 34, 339, DateTimeKind.Local).AddTicks(167) },
                    { "ad712968-7145-4c87-be43-e30e75d97e41", "Engleska", new DateTime(2022, 11, 29, 16, 1, 34, 339, DateTimeKind.Local).AddTicks(930) },
                    { "c019a187-82ac-4aba-a744-301588257250", "Persiska", new DateTime(2022, 11, 29, 16, 1, 34, 339, DateTimeKind.Local).AddTicks(926) }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "Name", "PhoneNumber", "Register" },
                values: new object[,]
                {
                    { "075138be-b34f-4199-972b-7e8a3b31fddd", 32, "Ali", "123456", new DateTime(2022, 11, 29, 16, 1, 34, 339, DateTimeKind.Local).AddTicks(946) },
                    { "49a35039-7fab-4dca-a8a1-dde310fcf906", 32, "Ali 2", "123456", new DateTime(2022, 11, 29, 16, 1, 34, 339, DateTimeKind.Local).AddTicks(955) },
                    { "ba2656cd-c18f-45df-9932-7711b34da98b", 32, "Ali", "123456", new DateTime(2022, 11, 29, 16, 1, 34, 339, DateTimeKind.Local).AddTicks(227) },
                    { "d55437b6-b13f-45ab-8596-dba93d6756d8", 32, "Ali 1", "123456", new DateTime(2022, 11, 29, 16, 1, 34, 339, DateTimeKind.Local).AddTicks(951) }
                });

            migrationBuilder.InsertData(
                table: "LanguagePerson",
                columns: new[] { "LanguagesId", "PeopleId" },
                values: new object[] { "5b577863-95fb-4cd8-b2e7-d0184fdc8fa2", "ba2656cd-c18f-45df-9932-7711b34da98b" });
        }
    }
}
