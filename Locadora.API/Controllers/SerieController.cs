using Locadora.Models;
using Locadora.Services;
using Locadora.ViewModel;
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
        List<Serie> _serie = new List<Serie>();
        private GestaoServices _serieServices = new GestaoServices();

        [HttpPost]
        public ActionResult CadastrarSerie([FromBody] SerieViewModel serieRecebida)
        {
            Serie serieCriada = _serieServices.CadastrarSerie(serieRecebida);
            return Created("serie", serieCriada); //"serie" é url(caminho)
        }
        
    }
}
