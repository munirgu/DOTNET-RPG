using DOTNET_RPG.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace DOTNET_RPG.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CharacterController : ControllerBase
    {
        private static List <Character> characters  = new List <Character>{
            new Character(),
            new Character {Name = "Munir"}
        };

        [HttpGet("GetAll")]
        public ActionResult <List<Character>> Get(){
            return Ok(characters);
        }

        [HttpGet]
        public ActionResult <Character> GetSingle(){
            return Ok(characters[0]);
        }
    }
}