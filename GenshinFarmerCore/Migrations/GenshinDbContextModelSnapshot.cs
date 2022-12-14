// <auto-generated />
using GenshinFarmerCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GenshinFarmerCore.Migrations
{
    [DbContext(typeof(GenshinDbContext))]
    partial class GenshinDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GenshinFarmerCore.Models.Database.Character", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            Id = "amber",
                            Name = "Amber"
                        });
                });

            modelBuilder.Entity("GenshinFarmerCore.Models.Database.Material", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("MaterialType")
                        .IsRequired()
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Materials");

                    b.HasData(
                        new
                        {
                            Id = "mora",
                            MaterialType = "other",
                            Name = "Mora"
                        },
                        new
                        {
                            Id = "agnidus-agate-sliver",
                            MaterialType = "character-ascension",
                            Name = "Agnidus Agate Sliver"
                        },
                        new
                        {
                            Id = "agnidus-agate-fragment",
                            MaterialType = "character-ascension",
                            Name = "Agnidus Agate Fragment"
                        },
                        new
                        {
                            Id = "agnidus-agate-chunk",
                            MaterialType = "character-ascension",
                            Name = "Agnidus Agate Chunk"
                        },
                        new
                        {
                            Id = "agnidus-agate-gemstone",
                            MaterialType = "character-ascension",
                            Name = "Agnidus Agate Gemstone"
                        },
                        new
                        {
                            Id = "everflame-seed",
                            MaterialType = "boss-material",
                            Name = "Everflame Seed"
                        },
                        new
                        {
                            Id = "small-lamp-grass",
                            MaterialType = "local-specialties",
                            Name = "Small Lamp Grass"
                        },
                        new
                        {
                            Id = "firm-arrowhead",
                            MaterialType = "common-ascension",
                            Name = "Firm Arrowhead"
                        },
                        new
                        {
                            Id = "sharp-arrowhead",
                            MaterialType = "common-ascension",
                            Name = "Sharp Arrowhead"
                        },
                        new
                        {
                            Id = "weathered-arrowhead",
                            MaterialType = "common-ascension",
                            Name = "Weathered Arrowhead"
                        });
                });

            modelBuilder.Entity("GenshinFarmerCore.Models.Database.Upgrade", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("CharacterId")
                        .HasColumnType("varchar(25)");

                    b.Property<long>("MaterialFiveAmount")
                        .HasColumnType("bigint");

                    b.Property<string>("MaterialFiveId")
                        .HasColumnType("varchar(50)");

                    b.Property<long>("MaterialFourAmount")
                        .HasColumnType("bigint");

                    b.Property<string>("MaterialFourId")
                        .HasColumnType("varchar(50)");

                    b.Property<long>("MaterialOneAmount")
                        .HasColumnType("bigint");

                    b.Property<string>("MaterialOneId")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<long>("MaterialThreeAmount")
                        .HasColumnType("bigint");

                    b.Property<string>("MaterialThreeId")
                        .HasColumnType("varchar(50)");

                    b.Property<long>("MaterialTwoAmount")
                        .HasColumnType("bigint");

                    b.Property<string>("MaterialTwoId")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("UpgradeType")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(25);

                    b.Property<string>("WeaponId")
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("MaterialFiveId");

                    b.HasIndex("MaterialFourId");

                    b.HasIndex("MaterialOneId");

                    b.HasIndex("MaterialThreeId");

                    b.HasIndex("MaterialTwoId");

                    b.HasIndex("WeaponId");

                    b.ToTable("Upgrades");

                    b.HasData(
                        new
                        {
                            Id = "asc_amber_1",
                            CharacterId = "amber",
                            MaterialFiveAmount = 0L,
                            MaterialFourAmount = 3L,
                            MaterialFourId = "firm-arrowhead",
                            MaterialOneAmount = 20000L,
                            MaterialOneId = "mora",
                            MaterialThreeAmount = 3L,
                            MaterialThreeId = "small-lamp-grass",
                            MaterialTwoAmount = 1L,
                            MaterialTwoId = "agnidus-agate-sliver",
                            UpgradeType = "ascension"
                        },
                        new
                        {
                            Id = "asc_amber_2",
                            CharacterId = "amber",
                            MaterialFiveAmount = 2L,
                            MaterialFiveId = "everflame-seed",
                            MaterialFourAmount = 15L,
                            MaterialFourId = "firm-arrowhead",
                            MaterialOneAmount = 40000L,
                            MaterialOneId = "mora",
                            MaterialThreeAmount = 10L,
                            MaterialThreeId = "small-lamp-grass",
                            MaterialTwoAmount = 3L,
                            MaterialTwoId = "agnidus-agate-fragment",
                            UpgradeType = "ascension"
                        },
                        new
                        {
                            Id = "asc_amber_3",
                            CharacterId = "amber",
                            MaterialFiveAmount = 4L,
                            MaterialFiveId = "everflame-seed",
                            MaterialFourAmount = 12L,
                            MaterialFourId = "sharp-arrowhead",
                            MaterialOneAmount = 60000L,
                            MaterialOneId = "mora",
                            MaterialThreeAmount = 20L,
                            MaterialThreeId = "small-lamp-grass",
                            MaterialTwoAmount = 6L,
                            MaterialTwoId = "agnidus-agate-fragment",
                            UpgradeType = "ascension"
                        },
                        new
                        {
                            Id = "asc_amber_4",
                            CharacterId = "amber",
                            MaterialFiveAmount = 8L,
                            MaterialFiveId = "everflame-seed",
                            MaterialFourAmount = 18L,
                            MaterialFourId = "sharp-arrowhead",
                            MaterialOneAmount = 80000L,
                            MaterialOneId = "mora",
                            MaterialThreeAmount = 30L,
                            MaterialThreeId = "small-lamp-grass",
                            MaterialTwoAmount = 3L,
                            MaterialTwoId = "agnidus-agate-chunk",
                            UpgradeType = "ascension"
                        },
                        new
                        {
                            Id = "asc_amber_5",
                            CharacterId = "amber",
                            MaterialFiveAmount = 12L,
                            MaterialFiveId = "everflame-seed",
                            MaterialFourAmount = 12L,
                            MaterialFourId = "weathered-arrowhead",
                            MaterialOneAmount = 100000L,
                            MaterialOneId = "mora",
                            MaterialThreeAmount = 45L,
                            MaterialThreeId = "small-lamp-grass",
                            MaterialTwoAmount = 6L,
                            MaterialTwoId = "agnidus-agate-chunk",
                            UpgradeType = "ascension"
                        },
                        new
                        {
                            Id = "asc_amber_6",
                            CharacterId = "amber",
                            MaterialFiveAmount = 20L,
                            MaterialFiveId = "everflame-seed",
                            MaterialFourAmount = 24L,
                            MaterialFourId = "weathered-arrowhead",
                            MaterialOneAmount = 120000L,
                            MaterialOneId = "mora",
                            MaterialThreeAmount = 60L,
                            MaterialThreeId = "small-lamp-grass",
                            MaterialTwoAmount = 6L,
                            MaterialTwoId = "agnidus-agate-gemstone",
                            UpgradeType = "ascension"
                        });
                });

            modelBuilder.Entity("GenshinFarmerCore.Models.Database.Weapon", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Weapons");
                });

            modelBuilder.Entity("GenshinFarmerCore.Models.Database.Upgrade", b =>
                {
                    b.HasOne("GenshinFarmerCore.Models.Database.Character", "Character")
                        .WithMany("Upgrades")
                        .HasForeignKey("CharacterId");

                    b.HasOne("GenshinFarmerCore.Models.Database.Material", "MaterialFive")
                        .WithMany("UpgradesFive")
                        .HasForeignKey("MaterialFiveId");

                    b.HasOne("GenshinFarmerCore.Models.Database.Material", "MaterialFour")
                        .WithMany("UpgradesFour")
                        .HasForeignKey("MaterialFourId");

                    b.HasOne("GenshinFarmerCore.Models.Database.Material", "MaterialOne")
                        .WithMany("UpgradesOne")
                        .HasForeignKey("MaterialOneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GenshinFarmerCore.Models.Database.Material", "MaterialThree")
                        .WithMany("UpgradesThree")
                        .HasForeignKey("MaterialThreeId");

                    b.HasOne("GenshinFarmerCore.Models.Database.Material", "MaterialTwo")
                        .WithMany("UpgradesTwo")
                        .HasForeignKey("MaterialTwoId");

                    b.HasOne("GenshinFarmerCore.Models.Database.Weapon", "Weapon")
                        .WithMany("Upgrades")
                        .HasForeignKey("WeaponId");
                });
#pragma warning restore 612, 618
        }
    }
}
