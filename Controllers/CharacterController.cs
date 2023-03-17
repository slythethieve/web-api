using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using web_api.Models;

namespace web_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        // Static mock character
        private static List<Character> characters = new List<Character>() {
            new Character(),
            new Character{ Id = 1, Name = "Douchebag"}
        };

        [HttpGet("GetAll")]
        public ActionResult<List<Character>> GetAll() {

            // Ok sends back a status code 200
            return Ok(characters);
        }

        // Only return a single character. For now return the first
        [HttpGet("GetSingle/{id}")]
        public ActionResult<Character> GetSingle(int id) {

            
            return Ok(characters.FirstOrDefault(c => c.Id == id));
        }
    }
}