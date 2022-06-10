using Locadora.Models;
using Locadora.Services;
using Locadora.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Locadora.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SerieController : ControllerBase
    {
        
        public SerieServices _serieServices = new SerieServices();
        // GET: api/Serie
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Serie/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Serie
        [HttpPost]
        public ActionResult CadastrarSerie(
            [FromBody] SerieViewModel serieRecebida)
        {
            if (serieRecebida == null)
            {
                return BadRequest("não foi recebido nenhum usuário.");
            }
            string TituloDaSerie = serieRecebida.Titulo;
            if (string.IsNullOrEmpty(TituloDaSerie))
            {
                return BadRequest("Não foi recebido nenhum usuario");
            }
           


            Serie objetoCriado = _serieServices.CadastrarSeries(serieRecebida);
            return Created("serie", objetoCriado);
        }

        // PUT: api/Serie/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
