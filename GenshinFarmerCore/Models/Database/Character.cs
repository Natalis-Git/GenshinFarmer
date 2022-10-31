
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GenshinFarmerCore.Models.Database.Interfaces;



namespace GenshinFarmerCore.Models.Database
{
    /// <summary>
    /// Represents in-game playable character and its upgrades. 
    /// All playable characters consist of 6 "ascension" upgrade tiers and 10 "talent" upgrade tiers.
    /// </summary>
    public class Character : IDbModel
    {
        [Required]
        [MaxLength(25)]
        [Column(TypeName = "varchar(25)")]
        public string Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        [Required]
        public ICollection<Upgrade> Upgrades { get; set; }
    }
}
