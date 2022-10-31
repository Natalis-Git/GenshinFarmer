
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GenshinFarmerCore.Models.Database.Interfaces;



namespace GenshinFarmerCore.Models.Database
{
    /// <summary>
    /// Represents in-game equipable weapon and its upgrades. All weapons consist of 6 upgrade tiers.
    /// </summary>
    public class Weapon : IDbModel
    {
        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        [Required]
        public ICollection<Upgrade> Upgrades { get; set; }
    }
}
