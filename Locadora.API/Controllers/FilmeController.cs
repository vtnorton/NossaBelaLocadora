using Locadora.Models;
using Locadora.Services;
using Locadora.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Locadora.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FilmeController : ControllerBase
    {
        List<Item> _filme = new List<Item>();
        private GestaoServices _filmeServices = new GestaoServices();
        

        [HttpPost]
        public ActionResult CadastrarFilme([FromBody] FilmeViewModel filmeRecebido)
        {
            Item filmeCriado = _filmeServices.CadastrarFilme(filmeRecebido);
            return Created("filme", filmeCriado);
        }

    }
}
