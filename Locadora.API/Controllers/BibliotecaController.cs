using Locadora.API.Services;
using Locadora.Models;
using Locadora.Repository;
using Locadora.Services;
using Locadora.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Locadora.API.Controllers
{
    [ApiController]
    [Route("biblioteca")]
    public class BibliotecaController : ControllerBase
    {
        private GestaoServices _gestaoServices = new GestaoServices();

        [HttpGet]
        public IActionResult ObterBiblioteca()
        {
            List<object> listaItem = _gestaoServices.ListarItens();
            return Ok(listaItem);
        }

        /*
         * https://localhost:5001/locadora
         * HTTPS => Protocolo
         * localhost => aonde está o site
         * 5001 => porta que o servidor está usando
         * locadora => rota
         * 
         * https://localhost:5001/api/locadora
         */
    }
}
