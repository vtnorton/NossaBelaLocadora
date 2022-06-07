using Locadora.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace Locadora.API.Controllers
{
    [ApiController]
    [Route("biblioteca")]
    public class BibliotecaController : ControllerBase
    {
        private static List<Item> itens = new List<Item>();
        /*
         * https://localhost:5001/locadora
         * HTTPS => Protocolo
         * localhost => aonde está o site
         * 5001 => porta que o servidor está usando
         * locadora => rota
         * 
         * https://localhost:5001/api/locadora
         */
        [HttpGet]
        public IActionResult ItensBiblioteca()
        {
            return Ok(itens);
        }
    }
}
