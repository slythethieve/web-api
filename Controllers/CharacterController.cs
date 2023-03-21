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
        public ActionResult<List<Character>> GetAll() {

            return Ok(_characterService.GetAllCharacters());
        }

        [HttpGet("GetSingle/{id}")]
        public ActionResult<Character> GetSingle(int id) {

            
            return Ok(_characterService.GetCharacterById(id));
        }

        [HttpPost]
        public ActionResult<List<Character>> AddCharacter(Character newCharacter) {

            return Ok(_characterService.AddCharacter(newCharacter));
        }
    }
}