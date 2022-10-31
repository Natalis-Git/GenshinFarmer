
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
    public class CharacterController : ControllerBase
    {
        private readonly IGenshinRepo _repo;
        private readonly IMapper _mapper;

        public CharacterController(IGenshinRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<ICollection<CharacterDto>>> GetCharacters()
        {
            var characters = await _repo.GetAllCharactersAsync();

            if (characters == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            return Ok(_mapper.Map<ICollection<CharacterDto>>(characters));
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterDto>> GetCharacter(string id)
        {
            var character = await _repo.GetCharacterByIdAsync(id);

            if (character == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<CharacterDto>(character));
        }
    }
}
