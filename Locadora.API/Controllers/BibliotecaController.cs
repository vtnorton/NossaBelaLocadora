using Locadora.Models;
using Locadora.Respository;
using Locadora.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Locadora.API.Controllers
{
    [ApiController]
    [Route("biblioteca")]
    public class BibliotecaController : ControllerBase
    {
        private GestaoServices _serviços = new GestaoServices();
        
        [HttpGet]
        public ActionResult ObterBiblioteca()
        {
           
            return Ok(_serviços.ListarItens());
        }
    }
    
}
