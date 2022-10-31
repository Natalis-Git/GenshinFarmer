
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GenshinFarmerCore.Models.Database;



namespace GenshinFarmerCore.Data
{
    public class GenshinSqlRepo : IGenshinRepo
    {
        private readonly GenshinDbContext _context;


        public GenshinSqlRepo(GenshinDbContext context)
        {
            _context = context;
        }


        public ICollection<Character> GetAllCharacters()
        {
            return _context.Characters.ToList();
        }

        public async Task<ICollection<Character>> GetAllCharactersAsync()
        {
            return await _context.Characters.ToListAsync();
        }


        public ICollection<Weapon> GetAllWeapons()
        {
            return _context.Weapons.ToList();
        }


        public async Task<ICollection<Weapon>> GetAllWeaponsAsync()
        {
            return await _context.Weapons.ToListAsync();
        }


        public async Task<Character> GetCharacterByIdAsync(string id)
        {
            var character = await _context.Characters
                .Include(c => c.Upgrades)
                .ThenInclude(u => u.MaterialOne)
                .Include(c => c.Upgrades)
                .ThenInclude(u => u.MaterialTwo)
                .Include(c => c.Upgrades)
                .ThenInclude(u => u.MaterialThree)
                .Include(c => c.Upgrades)
                .ThenInclude(u => u.MaterialFour)
                .Include(c => c.Upgrades)
                .ThenInclude(u => u.MaterialFive)

                .SingleAsync(c => c.Id == id);

            return character;
        }


        public async Task<Weapon> GetWeaponByIdAsync(string id)
        {
            var weapon = await _context.Weapons
                .Include(c => c.Upgrades)
                .ThenInclude(u => u.MaterialOne)
                .Include(c => c.Upgrades)
                .ThenInclude(u => u.MaterialTwo)
                .Include(c => c.Upgrades)
                .ThenInclude(u => u.MaterialThree)
                .Include(c => c.Upgrades)

                .SingleAsync(c => c.Id == id);

            return weapon;
        }


        public ICollection<Upgrade> GetAllUpgrades()
        {
            return _context.Upgrades.ToList();
        }


        public async Task<ICollection<Upgrade>> GetAllUpgradesAsync()
        {
            return await _context.Upgrades.ToListAsync();
        }


        public ICollection<Material> GetAllMaterials()
        {
            return _context.Materials.ToList();
        }


        public async Task<ICollection<Material>> GetAllMaterialsAsync()
        {
            return await _context.Materials.ToListAsync();
        }


        /// <remarks>Note: For admin client usage. Saves changes.</remarks>
        public void AddCharacter(Character character)
        {
            _context.Characters.Add(character);
            _context.SaveChanges();
        }


        /// <remarks>Note: for admin client usage. Saves changes.</remarks>
        public void UpdateCharacter(Character character)
        {
            _context.Characters.Update(character);
            _context.SaveChanges();
        }


        /// <remarks>Note: for admin client usage. Saves changes.</remarks>
        public void AddWeapon(Weapon weapon)
        {
            _context.Weapons.Add(weapon);
            _context.SaveChanges();
        }


        /// <remarks>Note: for admin client usage. Saves changes.</remarks>
        public void UpdateWeapon(Weapon weapon)
        {
            _context.Weapons.Update(weapon);
            _context.SaveChanges();
        }


        /// <remarks>Note: for admin client usage. Saves changes.</remarks>
        public void AddUpgrade(Upgrade upgrade)
        {
            _context.Upgrades.Add(upgrade);
            _context.SaveChanges();
        }


        /// <remarks>Note: For admin  usage. Saves changes.</remarks>
        public void UpdateUpgrade(Upgrade upgrade)
        {
            _context.Upgrades.Update(upgrade);
            _context.SaveChanges();
        }


        /// <remarks>Note: for admin client usage. Saves changes.</remarks>
        public void AddMaterial(Material material)
        {
            _context.Materials.Add(material);
            _context.SaveChanges();
        }


        /// <remarks>Note: for admin client usage. Saves changes.</remarks>
        public void UpdateMaterial(Material material)
        {
            _context.Materials.Update(material);
            _context.SaveChanges();
        }
    }
}
