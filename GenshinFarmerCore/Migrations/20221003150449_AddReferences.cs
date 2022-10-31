using Microsoft.EntityFrameworkCore.Migrations;

namespace GenshinFarmerCore.Migrations
{
    public partial class AddReferences : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Weapons_Id",
                table: "Weapons",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Upgrades_Id",
                table: "Upgrades",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Materials_Id",
                table: "Materials",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Characters_Id",
                table: "Characters",
                column: "Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Weapons_Id",
                table: "Weapons");

            migrationBuilder.DropIndex(
                name: "IX_Upgrades_Id",
                table: "Upgrades");

            migrationBuilder.DropIndex(
                name: "IX_Materials_Id",
                table: "Materials");

            migrationBuilder.DropIndex(
                name: "IX_Characters_Id",
                table: "Characters");
        }
    }
}
