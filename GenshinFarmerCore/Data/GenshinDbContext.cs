
using System;
using Microsoft.EntityFrameworkCore;
using GenshinFarmerCore.Models.Database;



namespace GenshinFarmerCore.Data
{
    public class GenshinDbContext : DbContext
    {
        public DbSet<Material> Materials { get; set; }
        public DbSet<Upgrade> Upgrades { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Weapon> Weapons { get; set; }

        public GenshinDbContext(DbContextOptions<GenshinDbContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Set unique constraint to keys
            modelBuilder.Entity<Character>()
                .HasIndex(i => i.Id)
                .IsUnique();

            modelBuilder.Entity<Weapon>()
                .HasIndex(i => i.Id)
                .IsUnique();

            modelBuilder.Entity<Upgrade>()
                .HasIndex(i => i.Id)
                .IsUnique();

            modelBuilder.Entity<Material>()
                .HasIndex(i => i.Id)
                .IsUnique();


            // Setting relationships and their respective foreign keys
            modelBuilder.Entity<Character>()
                .HasMany<Upgrade>(c => c.Upgrades)
                .WithOne(u => u.Character)
                .HasForeignKey(u => u.CharacterId);

            modelBuilder.Entity<Weapon>()
                .HasMany<Upgrade>(w => w.Upgrades)
                .WithOne(u => u.Weapon)
                .HasForeignKey(u => u.WeaponId);

            modelBuilder.Entity<Material>()
                .HasMany<Upgrade>(m => m.UpgradesOne)
                .WithOne(u => u.MaterialOne)
                .HasForeignKey(u => u.MaterialOneId);

            modelBuilder.Entity<Material>()
                .HasMany<Upgrade>(m => m.UpgradesTwo)
                .WithOne(u => u.MaterialTwo)
                .HasForeignKey(u => u.MaterialTwoId);

            modelBuilder.Entity<Material>()
                .HasMany<Upgrade>(m => m.UpgradesThree)
                .WithOne(u => u.MaterialThree)
                .HasForeignKey(u => u.MaterialThreeId);

            modelBuilder.Entity<Material>()
                .HasMany<Upgrade>(m => m.UpgradesFour)
                .WithOne(u => u.MaterialFour)
                .HasForeignKey(u => u.MaterialFourId);

            modelBuilder.Entity<Material>()
                .HasMany<Upgrade>(m => m.UpgradesFive)
                .WithOne(u => u.MaterialFive)
                .HasForeignKey(u => u.MaterialFiveId);


            // Populate with intial data set
            DbSeeder.PopulateEntities(modelBuilder);
        }
    }
}
