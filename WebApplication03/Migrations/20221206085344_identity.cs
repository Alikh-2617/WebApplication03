using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication03.Migrations
{
    public partial class identity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "552443b2-6831-4720-8023-43f843fa1d9f");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "b4b589b9-e05b-41e7-a706-1cb2751d0beb");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "e27cbb32-ff29-4884-a94c-8b7b60bc2b2f");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "0b6fdd2f-e148-4b35-aa63-5b863359821a");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "5c97ca1e-d39a-4958-9d88-c37f62bbff81");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "aaeceb46-e21a-4904-aa61-e5f802ca0890");

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { "e6dbf485-c2a6-40bf-ac55-3667cafa4c39", "f5522beb-c267-4461-8d7c-53e2246adc5a" });

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "883e5698-b1a8-4ea7-819f-4a5079df4949");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "964212fe-169e-47d7-b581-dd91fd5d153b");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "ebdc3afb-727b-4e94-a70e-d5589a810f47");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "2163f1c3-18b9-4273-b25b-eb4b45b0fd49");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "7c544e13-ff95-42bd-9d98-4fc006fda9f8");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "f1cbc93c-af18-4d05-ab0e-e39fd146e32f");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "e6dbf485-c2a6-40bf-ac55-3667cafa4c39");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "f5522beb-c267-4461-8d7c-53e2246adc5a");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EfterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Register = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "Name", "PostNumber", "Register" },
                values: new object[,]
                {
                    { "2814a72c-7bff-49db-91d4-986eb29ba55b", null, "Mörsil", "415 44", new DateTime(2022, 12, 6, 9, 53, 44, 493, DateTimeKind.Local).AddTicks(9667) },
                    { "89be939e-3d67-47e4-b35b-81aee71653df", null, "GBG", "415 52", new DateTime(2022, 12, 6, 9, 53, 44, 493, DateTimeKind.Local).AddTicks(9657) },
                    { "f8ae0a98-e042-49f7-bcbd-c18cbf7efd70", null, "Järpen", "415 55", new DateTime(2022, 12, 6, 9, 53, 44, 493, DateTimeKind.Local).AddTicks(9663) }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[,]
                {
                    { "3a6a79f6-a2ca-4396-bc9e-b87a2bc7685a", "Danmarc", new DateTime(2022, 12, 6, 9, 53, 44, 493, DateTimeKind.Local).AddTicks(9703) },
                    { "5bccfdd9-4d1b-4d74-9cd3-0e05edc1d17a", "Norway", new DateTime(2022, 12, 6, 9, 53, 44, 493, DateTimeKind.Local).AddTicks(9699) },
                    { "7ee608b6-b7b0-4c2f-847f-3d636db3f80b", "Sweden", new DateTime(2022, 12, 6, 9, 53, 44, 493, DateTimeKind.Local).AddTicks(9694) }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[,]
                {
                    { "006971a6-37b1-42c8-b930-03df0ef8dc25", "Svenska", new DateTime(2022, 12, 6, 9, 53, 44, 493, DateTimeKind.Local).AddTicks(8632) },
                    { "6764cbf0-10fb-4afd-a51f-324095b77613", "Engleska", new DateTime(2022, 12, 6, 9, 53, 44, 493, DateTimeKind.Local).AddTicks(9591) },
                    { "6922fc85-4583-460c-8ef9-13630decd90e", "Svenska", new DateTime(2022, 12, 6, 9, 53, 44, 493, DateTimeKind.Local).AddTicks(9575) },
                    { "a0ec5cce-3d17-4cde-a837-3eed86a30b9a", "Persiska", new DateTime(2022, 12, 6, 9, 53, 44, 493, DateTimeKind.Local).AddTicks(9586) }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "CityId", "Name", "PhoneNumber", "Register" },
                values: new object[,]
                {
                    { "5d98aa9a-d128-4701-b307-d8084c2282d0", 32, null, "Ali", "123456", new DateTime(2022, 12, 6, 9, 53, 44, 493, DateTimeKind.Local).AddTicks(8697) },
                    { "96f0d0da-0e49-4b46-8bf7-06ecf8bb4309", 32, null, "Ali", "123456", new DateTime(2022, 12, 6, 9, 53, 44, 493, DateTimeKind.Local).AddTicks(9608) },
                    { "9cdd9411-8f08-4404-b795-f6273b2c6576", 32, null, "Ali 1", "123456", new DateTime(2022, 12, 6, 9, 53, 44, 493, DateTimeKind.Local).AddTicks(9625) },
                    { "be403573-befb-4374-9cc3-5caef859ec6c", 32, null, "Ali 2", "123456", new DateTime(2022, 12, 6, 9, 53, 44, 493, DateTimeKind.Local).AddTicks(9636) }
                });

            migrationBuilder.InsertData(
                table: "LanguagePerson",
                columns: new[] { "LanguagesId", "PeopleId" },
                values: new object[] { "006971a6-37b1-42c8-b930-03df0ef8dc25", "5d98aa9a-d128-4701-b307-d8084c2282d0" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "2814a72c-7bff-49db-91d4-986eb29ba55b");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "89be939e-3d67-47e4-b35b-81aee71653df");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: "f8ae0a98-e042-49f7-bcbd-c18cbf7efd70");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "3a6a79f6-a2ca-4396-bc9e-b87a2bc7685a");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "5bccfdd9-4d1b-4d74-9cd3-0e05edc1d17a");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "7ee608b6-b7b0-4c2f-847f-3d636db3f80b");

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { "006971a6-37b1-42c8-b930-03df0ef8dc25", "5d98aa9a-d128-4701-b307-d8084c2282d0" });

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "6764cbf0-10fb-4afd-a51f-324095b77613");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "6922fc85-4583-460c-8ef9-13630decd90e");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "a0ec5cce-3d17-4cde-a837-3eed86a30b9a");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "96f0d0da-0e49-4b46-8bf7-06ecf8bb4309");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "9cdd9411-8f08-4404-b795-f6273b2c6576");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "be403573-befb-4374-9cc3-5caef859ec6c");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "006971a6-37b1-42c8-b930-03df0ef8dc25");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "5d98aa9a-d128-4701-b307-d8084c2282d0");

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "Name", "PostNumber", "Register" },
                values: new object[,]
                {
                    { "552443b2-6831-4720-8023-43f843fa1d9f", null, "Järpen", "415 55", new DateTime(2022, 12, 1, 21, 26, 9, 653, DateTimeKind.Local).AddTicks(9994) },
                    { "b4b589b9-e05b-41e7-a706-1cb2751d0beb", null, "Mörsil", "415 44", new DateTime(2022, 12, 1, 21, 26, 9, 653, DateTimeKind.Local).AddTicks(9998) },
                    { "e27cbb32-ff29-4884-a94c-8b7b60bc2b2f", null, "GBG", "415 52", new DateTime(2022, 12, 1, 21, 26, 9, 653, DateTimeKind.Local).AddTicks(9989) }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[,]
                {
                    { "0b6fdd2f-e148-4b35-aa63-5b863359821a", "Sweden", new DateTime(2022, 12, 1, 21, 26, 9, 654, DateTimeKind.Local).AddTicks(20) },
                    { "5c97ca1e-d39a-4958-9d88-c37f62bbff81", "Norway", new DateTime(2022, 12, 1, 21, 26, 9, 654, DateTimeKind.Local).AddTicks(27) },
                    { "aaeceb46-e21a-4904-aa61-e5f802ca0890", "Danmarc", new DateTime(2022, 12, 1, 21, 26, 9, 654, DateTimeKind.Local).AddTicks(32) }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[,]
                {
                    { "883e5698-b1a8-4ea7-819f-4a5079df4949", "Engleska", new DateTime(2022, 12, 1, 21, 26, 9, 653, DateTimeKind.Local).AddTicks(9940) },
                    { "964212fe-169e-47d7-b581-dd91fd5d153b", "Persiska", new DateTime(2022, 12, 1, 21, 26, 9, 653, DateTimeKind.Local).AddTicks(9925) },
                    { "e6dbf485-c2a6-40bf-ac55-3667cafa4c39", "Svenska", new DateTime(2022, 12, 1, 21, 26, 9, 653, DateTimeKind.Local).AddTicks(9013) },
                    { "ebdc3afb-727b-4e94-a70e-d5589a810f47", "Svenska", new DateTime(2022, 12, 1, 21, 26, 9, 653, DateTimeKind.Local).AddTicks(9915) }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "CityId", "Name", "PhoneNumber", "Register" },
                values: new object[,]
                {
                    { "2163f1c3-18b9-4273-b25b-eb4b45b0fd49", 32, null, "Ali 2", "123456", new DateTime(2022, 12, 1, 21, 26, 9, 653, DateTimeKind.Local).AddTicks(9972) },
                    { "7c544e13-ff95-42bd-9d98-4fc006fda9f8", 32, null, "Ali 1", "123456", new DateTime(2022, 12, 1, 21, 26, 9, 653, DateTimeKind.Local).AddTicks(9968) },
                    { "f1cbc93c-af18-4d05-ab0e-e39fd146e32f", 32, null, "Ali", "123456", new DateTime(2022, 12, 1, 21, 26, 9, 653, DateTimeKind.Local).AddTicks(9963) },
                    { "f5522beb-c267-4461-8d7c-53e2246adc5a", 32, null, "Ali", "123456", new DateTime(2022, 12, 1, 21, 26, 9, 653, DateTimeKind.Local).AddTicks(9082) }
                });

            migrationBuilder.InsertData(
                table: "LanguagePerson",
                columns: new[] { "LanguagesId", "PeopleId" },
                values: new object[] { "e6dbf485-c2a6-40bf-ac55-3667cafa4c39", "f5522beb-c267-4461-8d7c-53e2246adc5a" });
        }
    }
}
