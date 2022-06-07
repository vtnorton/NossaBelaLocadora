using Locadora.Models;
using Locadora.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Locadora.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SerieController : ControllerBase
    {
        List<Item> _serie = new List<Item>();
        private LocacaoService _serieServices = new LocacaoService();

        [HttpPost]
        public ActionResult CadastrarSerie([FromBody] SerieViewModel serieRecebida)
        {
            
            string nomeDaSerie = serieRecebida.Titulo;
            int valorDoItem = serieRecebida.Valor;
            Item serieCriada = _serieServices.CadastrarSerie(serieRecebida);
            return Created("usuarios", serieCriada);
        }

      
    }
}
