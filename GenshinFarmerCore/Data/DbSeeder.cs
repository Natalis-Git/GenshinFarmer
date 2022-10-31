
using System;
using Microsoft.EntityFrameworkCore;
using GenshinFarmerCore.Models.Database;



namespace GenshinFarmerCore.Data
{
    // For populating database with initial data set to allow for testing
    public static class DbSeeder
    {
        public static void PopulateEntities(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Material>().HasData(
                new Material { Id = "mora", Name = "Mora", MaterialType = "other" },
                new Material { Id = "agnidus-agate-sliver", Name = "Agnidus Agate Sliver", MaterialType = "character-ascension" },
                new Material { Id = "agnidus-agate-fragment", Name = "Agnidus Agate Fragment", MaterialType = "character-ascension" },
                new Material { Id = "agnidus-agate-chunk", Name = "Agnidus Agate Chunk", MaterialType = "character-ascension" },
                new Material { Id = "agnidus-agate-gemstone", Name = "Agnidus Agate Gemstone", MaterialType = "character-ascension"},
                new Material { Id = "everflame-seed", Name = "Everflame Seed", MaterialType = "boss-material" },
                new Material { Id = "small-lamp-grass", Name = "Small Lamp Grass", MaterialType = "local-specialties"},
                new Material { Id = "firm-arrowhead", Name = "Firm Arrowhead", MaterialType = "common-ascension" },
                new Material { Id = "sharp-arrowhead", Name = "Sharp Arrowhead", MaterialType = "common-ascension" },
                new Material { Id = "weathered-arrowhead", Name = "Weathered Arrowhead", MaterialType = "common-ascension" }
            );


            modelBuilder.Entity<Character>().HasData(new { Id = "amber", Name = "Amber" });


            modelBuilder.Entity<Upgrade>().HasData(
                new Upgrade { Id = "asc_amber_1", UpgradeType = "ascension", 
                MaterialOneId = "mora", MaterialOneAmount = 20000,
                MaterialTwoId = "agnidus-agate-sliver", MaterialTwoAmount = 1,
                MaterialThreeId = "small-lamp-grass", MaterialThreeAmount = 3,
                MaterialFourId = "firm-arrowhead", MaterialFourAmount = 3,
                MaterialFiveId = null, MaterialFiveAmount = 0,
                CharacterId = "amber" },
                
                new Upgrade { Id = "asc_amber_2", UpgradeType = "ascension", 
                MaterialOneId = "mora", MaterialOneAmount = 40000,
                MaterialTwoId = "agnidus-agate-fragment", MaterialTwoAmount = 3,
                MaterialThreeId = "small-lamp-grass", MaterialThreeAmount = 10,
                MaterialFourId = "firm-arrowhead", MaterialFourAmount = 15,
                MaterialFiveId = "everflame-seed", MaterialFiveAmount = 2,
                CharacterId = "amber" },

                new Upgrade { Id = "asc_amber_3", UpgradeType = "ascension", 
                MaterialOneId = "mora", MaterialOneAmount = 60000,
                MaterialTwoId = "agnidus-agate-fragment", MaterialTwoAmount = 6,
                MaterialThreeId = "small-lamp-grass", MaterialThreeAmount = 20,
                MaterialFourId = "sharp-arrowhead", MaterialFourAmount = 12,
                MaterialFiveId = "everflame-seed", MaterialFiveAmount = 4,
                CharacterId = "amber" },

                new Upgrade { Id = "asc_amber_4", UpgradeType = "ascension", 
                MaterialOneId = "mora", MaterialOneAmount = 80000,
                MaterialTwoId = "agnidus-agate-chunk", MaterialTwoAmount = 3,
                MaterialThreeId = "small-lamp-grass", MaterialThreeAmount = 30,
                MaterialFourId = "sharp-arrowhead", MaterialFourAmount = 18,
                MaterialFiveId = "everflame-seed", MaterialFiveAmount = 8,
                CharacterId = "amber" },

                new Upgrade { Id = "asc_amber_5", UpgradeType = "ascension", 
                MaterialOneId = "mora", MaterialOneAmount = 100000,
                MaterialTwoId = "agnidus-agate-chunk", MaterialTwoAmount = 6,
                MaterialThreeId = "small-lamp-grass", MaterialThreeAmount = 45,
                MaterialFourId = "weathered-arrowhead", MaterialFourAmount = 12,
                MaterialFiveId = "everflame-seed", MaterialFiveAmount = 12,
                CharacterId = "amber" },

                new Upgrade { Id = "asc_amber_6", UpgradeType = "ascension", 
                MaterialOneId = "mora", MaterialOneAmount = 120000,
                MaterialTwoId = "agnidus-agate-gemstone", MaterialTwoAmount = 6,
                MaterialThreeId = "small-lamp-grass", MaterialThreeAmount = 60,
                MaterialFourId = "weathered-arrowhead", MaterialFourAmount = 24,
                MaterialFiveId = "everflame-seed", MaterialFiveAmount = 20,
                CharacterId = "amber" }
            );
        }
    }
}
