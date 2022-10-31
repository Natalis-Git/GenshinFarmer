
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GenshinFarmerCore.Models.Database.Interfaces;



namespace GenshinFarmerCore.Models.Database
{
    /// <summary>
    /// Represents base material for all farmable in-game objects. Lowest level entity for API and Database.
    /// </summary>
    public class Material : IDbModel
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
        [MaxLength(25)]
        [Column(TypeName = "varchar(25)")]
        public string MaterialType { get; set; }


        public ICollection<Upgrade> UpgradesOne { get; set; }

        public ICollection<Upgrade> UpgradesTwo { get; set; }

        public ICollection<Upgrade> UpgradesThree { get; set; }

        public ICollection<Upgrade> UpgradesFour { get; set; }

        public ICollection<Upgrade> UpgradesFive { get; set; }
    }
}
