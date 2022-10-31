
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GenshinFarmerCore.Models.Database.Interfaces;



namespace GenshinFarmerCore.Models.Database
{
    /// <summary>
    /// Represents 1 set/tier of required materials needed to craft and/or upgrade an in-game farmable object.
    /// The "central" point of the database, with which all entities have a one(entity) to many(upgrade) relationship.
    /// </summary>
    public class Upgrade : IDbModel
    {
        [Required]
        [MaxLength(25)]
        [Column(TypeName = "varchar(25)")]
        public string Id { get; set; }

        [Required]
        [MaxLength(25)]
        [Column(TypeName = "varchar(50)")]
        public string UpgradeType { get; set; }

        [Required]
        [ForeignKey("MaterialOneId")]
        public Material MaterialOne { get; set; }
        [Required]
        public string MaterialOneId { get; set; }
        [Required]
        public uint MaterialOneAmount { get; set; }


        [ForeignKey("MaterialTwoId")]
        public Material MaterialTwo { get; set; }
        public string MaterialTwoId { get; set; }
        public uint MaterialTwoAmount { get; set; }


        [ForeignKey("MaterialThreeId")]
        public Material MaterialThree { get; set; }
        public string MaterialThreeId { get; set; }
        public uint MaterialThreeAmount { get; set; }


        [ForeignKey("MaterialFourId")]
        public Material MaterialFour { get; set; }
        public string MaterialFourId { get; set; }
        public uint MaterialFourAmount { get; set; }


        [ForeignKey("MaterialFiveId")]
        public Material MaterialFive { get; set; }
        public string MaterialFiveId { get; set; }
        public uint MaterialFiveAmount { get; set; }

        
        [ForeignKey("CharacterId")]
        public Character Character { get; set; }
        public string CharacterId { get; set; }


        [ForeignKey("WeaponId")]
        public Weapon Weapon { get; set; }
        public string WeaponId { get; set; }
    }
}
