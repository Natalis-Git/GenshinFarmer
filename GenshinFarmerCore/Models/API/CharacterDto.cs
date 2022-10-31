

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;



namespace GenshinFarmerCore.Models.API
{
    public class CharacterDto
    {
        [Required]
        [MaxLength(25)]
        public string Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public ICollection<UpgradeDto> Upgrades { get; set; }
    }
}
