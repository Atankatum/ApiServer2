using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace apipi.Controllers
{

    [ApiController]
    [Route("api/pokemon")]
    public class Idiotapicontroller : ControllerBase
    {

        static List<Pokemon> pokemons = new List<Pokemon>()
        {
            new Pokemon() {name = "Pikachu"},
            new Pokemon() {name = "Mimikyu"},
            new Pokemon() {name = "Lickitung"}
        };



        [HttpGet]
        public ActionResult Get()
        {
            return Ok(pokemons[0]);
        }
    }
}
