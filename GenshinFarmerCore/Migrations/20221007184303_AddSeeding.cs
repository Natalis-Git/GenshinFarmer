using Microsoft.EntityFrameworkCore.Migrations;

namespace GenshinFarmerCore.Migrations
{
    public partial class AddSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Name" },
                values: new object[] { "amber", "Amber" });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "MaterialType", "Name" },
                values: new object[,]
                {
                    { "mora", "other", "Mora" },
                    { "agnidus-agate-sliver", "character-ascension", "Agnidus Agate Sliver" },
                    { "agnidus-agate-fragment", "character-ascension", "Agnidus Agate Fragment" },
                    { "agnidus-agate-chunk", "character-ascension", "Agnidus Agate Chunk" },
                    { "agnidus-agate-gemstone", "character-ascension", "Agnidus Agate Gemstone" },
                    { "everflame-seed", "boss-material", "Everflame Seed" },
                    { "small-lamp-grass", "local-specialties", "Small Lamp Grass" },
                    { "firm-arrowhead", "common-ascension", "Firm Arrowhead" },
                    { "sharp-arrowhead", "common-ascension", "Sharp Arrowhead" },
                    { "weathered-arrowhead", "common-ascension", "Weathered Arrowhead" }
                });

            migrationBuilder.InsertData(
                table: "Upgrades",
                columns: new[] { "Id", "CharacterId", "MaterialFiveAmount", "MaterialFiveId", "MaterialFourAmount", "MaterialFourId", "MaterialOneAmount", "MaterialOneId", "MaterialThreeAmount", "MaterialThreeId", "MaterialTwoAmount", "MaterialTwoId", "UpgradeType", "WeaponId" },
                values: new object[,]
                {
                    { "asc_amber_1", "amber", 0L, null, 3L, "firm-arrowhead", 20000L, "mora", 3L, "small-lamp-grass", 1L, "agnidus-agate-sliver", "ascension", null },
                    { "asc_amber_2", "amber", 2L, "everflame-seed", 15L, "firm-arrowhead", 40000L, "mora", 10L, "small-lamp-grass", 3L, "agnidus-agate-fragment", "ascension", null },
                    { "asc_amber_3", "amber", 4L, "everflame-seed", 12L, "sharp-arrowhead", 60000L, "mora", 20L, "small-lamp-grass", 6L, "agnidus-agate-fragment", "ascension", null },
                    { "asc_amber_4", "amber", 8L, "everflame-seed", 18L, "sharp-arrowhead", 80000L, "mora", 30L, "small-lamp-grass", 3L, "agnidus-agate-chunk", "ascension", null },
                    { "asc_amber_5", "amber", 12L, "everflame-seed", 12L, "weathered-arrowhead", 100000L, "mora", 45L, "small-lamp-grass", 6L, "agnidus-agate-chunk", "ascension", null },
                    { "asc_amber_6", "amber", 20L, "everflame-seed", 24L, "weathered-arrowhead", 120000L, "mora", 60L, "small-lamp-grass", 6L, "agnidus-agate-gemstone", "ascension", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Upgrades",
                keyColumn: "Id",
                keyValue: "asc_amber_1");

            migrationBuilder.DeleteData(
                table: "Upgrades",
                keyColumn: "Id",
                keyValue: "asc_amber_2");

            migrationBuilder.DeleteData(
                table: "Upgrades",
                keyColumn: "Id",
                keyValue: "asc_amber_3");

            migrationBuilder.DeleteData(
                table: "Upgrades",
                keyColumn: "Id",
                keyValue: "asc_amber_4");

            migrationBuilder.DeleteData(
                table: "Upgrades",
                keyColumn: "Id",
                keyValue: "asc_amber_5");

            migrationBuilder.DeleteData(
                table: "Upgrades",
                keyColumn: "Id",
                keyValue: "asc_amber_6");

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: "amber");

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: "agnidus-agate-chunk");

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: "agnidus-agate-fragment");

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: "agnidus-agate-gemstone");

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: "agnidus-agate-sliver");

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: "everflame-seed");

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: "firm-arrowhead");

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: "mora");

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: "sharp-arrowhead");

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: "small-lamp-grass");

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: "weathered-arrowhead");
        }
    }
}
