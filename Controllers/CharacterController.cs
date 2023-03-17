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
        private static Character fighter = new Character();

        [HttpGet]
        public ActionResult<Character> Get() {

            // Ok sends back a status code 200
            return Ok(fighter);
        }
    }
}