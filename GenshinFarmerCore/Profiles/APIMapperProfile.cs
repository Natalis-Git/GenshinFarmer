
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GenshinFarmerCore.Models.Database;
using GenshinFarmerCore.Models.API;



namespace GenshinFarmerCore.Profiles
{
    public class APIMapperProfile : Profile
    {
        public APIMapperProfile()
        {
            CreateMap<Material, MaterialDto>().ReverseMap();
            CreateMap<Character, CharacterDto>().ReverseMap();
            CreateMap<Weapon, WeaponDto>().ReverseMap();
            CreateMap<Upgrade, UpgradeDto>().ReverseMap();
        }
    }
}
