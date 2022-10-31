
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GenshinFarmerCore.Models.Database;



namespace GenshinFarmerCore.Data
{
    public interface IGenshinRepo
    {
        ICollection<Character> GetAllCharacters();
        Task<ICollection<Character>> GetAllCharactersAsync();
        ICollection<Weapon> GetAllWeapons();
        Task<ICollection<Weapon>> GetAllWeaponsAsync();
        Task<Character> GetCharacterByIdAsync(string id);
        Task<Weapon> GetWeaponByIdAsync(string id);
        ICollection<Upgrade> GetAllUpgrades();
        Task<ICollection<Upgrade>> GetAllUpgradesAsync();
        ICollection<Material> GetAllMaterials();
        Task<ICollection<Material>> GetAllMaterialsAsync();

        // Note: Methods below are for admin client usage.
        // TODO: Consider moving admin-exclusive methods to seperate Repo.
        void AddCharacter(Character character);
        void UpdateCharacter(Character character);
        void AddWeapon(Weapon weapon);
        void UpdateWeapon(Weapon weapon);
        void AddUpgrade(Upgrade upgrade);
        void UpdateUpgrade(Upgrade upgrade);
        void AddMaterial(Material material);
        void UpdateMaterial(Material material);
    }
}
