using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace web_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
            
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<Character>>> GetAll() {

            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("GetSingle/{id}")]
        public async Task<ActionResult<Character>> GetSingle(int id) {

            
            return Ok(await _characterService.GetCharacterById(id));
        }

        [HttpPost]
        public async Task<ActionResult<List<Character>>> AddCharacter(Character newCharacter) {

            return Ok(await _characterService.AddCharacter(newCharacter));
        }
    }
}