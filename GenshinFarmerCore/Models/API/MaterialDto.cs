
using System;
using System.ComponentModel.DataAnnotations;



namespace GenshinFarmerCore.Models.API
{
    public class MaterialDto
    {
        [Required]
        [MaxLength(50)]
        public string Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        
        [Required]
        [MaxLength(25)]
        public string MaterialType { get; set; }
    }
}
