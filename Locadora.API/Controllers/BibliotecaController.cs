using Locadora.Models;
using Locadora.Respository;
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
        public List<Item> ItensBiblioteca()
        {
            return Armazenamento.Biblioteca.ToList();
        }
    }
    
}
