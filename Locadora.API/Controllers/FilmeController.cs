using Locadora.Models;
using Locadora.Respository;
using Locadora.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Locadora.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FilmeController : ControllerBase
    {
        private FilmeServices _filmeServices = new FilmeServices();

        // GET: api/Filme
        [HttpGet]
        public List<Filme> ListarFilmes()
        {
            List<Filme> listafilmes = Armazenamento.Filmes.OrderBy(filme => filme.Titulo).ToList();
            return listafilmes;
        }

        // GET: api/Filme/5
        [HttpGet("{id}")]
        public IActionResult ObterFilme(string idFilme)
        {
            Filme filme = _filmeServices.ObterFilme(idFilme);
            if (filme == null)
            {
                return NotFound();
            }
            return Ok(filme);
        }
        // POST: api/Filme
        [HttpPost]
        public ActionResult CadastrarFilme([FromBody]  Filme filmeRecebido)
        {
            if (filmeRecebido == null)
            {
                return BadRequest("não foi recebido nenhum filme.");
            }
            string nomeDoFilme = filmeRecebido.Titulo;
            if (string.IsNullOrEmpty(nomeDoFilme))
            {
                return BadRequest("Não foi recebido nenhum filme");
            }



            Filme objetoCriado = Filme.CadastrarFilme(filmeRecebido);
            return Created("filme", objetoCriado);
        }

        // PUT: api/Filme/5
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