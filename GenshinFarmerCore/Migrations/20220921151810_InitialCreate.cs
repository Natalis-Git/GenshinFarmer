using Microsoft.EntityFrameworkCore.Migrations;

namespace GenshinFarmerCore.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    MaterialType = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Upgrades",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    UpgradeType = table.Column<string>(type: "varchar(50)", maxLength: 25, nullable: false),
                    MaterialOneId = table.Column<string>(nullable: false),
                    MaterialOneAmount = table.Column<long>(nullable: false),
                    MaterialTwoId = table.Column<string>(nullable: true),
                    MaterialTwoAmount = table.Column<long>(nullable: false),
                    MaterialThreeId = table.Column<string>(nullable: true),
                    MaterialThreeAmount = table.Column<long>(nullable: false),
                    MaterialFourId = table.Column<string>(nullable: true),
                    MaterialFourAmount = table.Column<long>(nullable: false),
                    MaterialFiveId = table.Column<string>(nullable: true),
                    MaterialFiveAmount = table.Column<long>(nullable: false),
                    CharacterId = table.Column<string>(nullable: true),
                    WeaponId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Upgrades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Upgrades_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Upgrades_Materials_MaterialFiveId",
                        column: x => x.MaterialFiveId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Upgrades_Materials_MaterialFourId",
                        column: x => x.MaterialFourId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Upgrades_Materials_MaterialOneId",
                        column: x => x.MaterialOneId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Upgrades_Materials_MaterialThreeId",
                        column: x => x.MaterialThreeId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Upgrades_Materials_MaterialTwoId",
                        column: x => x.MaterialTwoId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Upgrades_Weapons_WeaponId",
                        column: x => x.WeaponId,
                        principalTable: "Weapons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Upgrades_CharacterId",
                table: "Upgrades",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Upgrades_MaterialFiveId",
                table: "Upgrades",
                column: "MaterialFiveId");

            migrationBuilder.CreateIndex(
                name: "IX_Upgrades_MaterialFourId",
                table: "Upgrades",
                column: "MaterialFourId");

            migrationBuilder.CreateIndex(
                name: "IX_Upgrades_MaterialOneId",
                table: "Upgrades",
                column: "MaterialOneId");

            migrationBuilder.CreateIndex(
                name: "IX_Upgrades_MaterialThreeId",
                table: "Upgrades",
                column: "MaterialThreeId");

            migrationBuilder.CreateIndex(
                name: "IX_Upgrades_MaterialTwoId",
                table: "Upgrades",
                column: "MaterialTwoId");

            migrationBuilder.CreateIndex(
                name: "IX_Upgrades_WeaponId",
                table: "Upgrades",
                column: "WeaponId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Upgrades");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "Weapons");
        }
    }
}
