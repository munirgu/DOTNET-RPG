using DOTNET_RPG.Models;
using System.Linq;
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
            new Character {Id = 1, Name = "Munir"}
        };

        [HttpGet("GetAll")]
        public ActionResult <List<Character>> Get(){
            return Ok(characters);
        }

        [HttpGet("{id}")]
        public ActionResult <Character> GetSingle(int id){
            return Ok(characters.FirstOrDefault(c => c.Id==id));
        }

    
        [HttpPost]
        public ActionResult <List<Character>> AddCharacter(Character newcharacter){
            characters.Add(newcharacter);
            return Ok(characters);
        }
    }
}