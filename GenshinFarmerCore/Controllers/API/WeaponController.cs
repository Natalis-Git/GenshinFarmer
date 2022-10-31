
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using GenshinFarmerCore.Data;
using GenshinFarmerCore.Models.API;



namespace GenshinFarmerCore.Controllers.API
{

    [Route("api/[controller]")]
    [ApiController]
    public class WeaponController : ControllerBase
    {
        private readonly IGenshinRepo _repo;
        private readonly IMapper _mapper;

        public WeaponController(IGenshinRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<WeaponDto>> Getweapons()
        {
            var weapons = await _repo.GetAllWeaponsAsync();

            if (weapons == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            return Ok(_mapper.Map<ICollection<WeaponDto>>(weapons));
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<WeaponDto>> GetWeapon(string id)
        {
            var weapon = await _repo.GetWeaponByIdAsync(id);

            if (weapon == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ICollection<WeaponDto>>(weapon));
        }
    }

}
