
using System;
using System.ComponentModel.DataAnnotations;



namespace GenshinFarmerCore.Models.API
{
    public class UpgradeDto
    {
        [Required]
        [MaxLength(25)]
        public string Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string UpgradeType { get; set; }

        [Required]
        [MaxLength(50)]
        public string MaterialOneId { get; set; }
        [Required]
        public uint MaterialOneAmount { get; set; }

        [MaxLength(50)]
        public string MaterialTwoId { get; set; }
        public uint MaterialTwoAmount { get; set; }

        [MaxLength(50)]
        public string MaterialThreeId { get; set; }
        public uint MaterialThreeAmount { get; set; }

        [MaxLength(50)]
        public string MaterialFourId { get; set; }
        public uint MaterialFourAmount { get; set; }

        [MaxLength(50)]
        public string MaterialFiveId { get; set; }
        public uint MaterialFiveAmount { get; set; }

        [MaxLength(25)]
        public string CharacterId { get; set; }

        [MaxLength(50)]
        public string WeaponId { get; set; }
    }
}
