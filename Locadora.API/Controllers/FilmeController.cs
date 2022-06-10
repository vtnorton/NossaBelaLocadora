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
    [Route("filme")] // Alterado api/filme para filme
    public class FilmeController : BibliotecaController
    {
        private GestaoServices _gestaoServices = new GestaoServices();

        [HttpPost] // POST da api/filme
        public ActionResult CadastrarFilme(
            [FromBody] FilmeViewModel filmeRecebido)
        {
            if (filmeRecebido == null)
            {
                return BadRequest("Nenhum cadastro de filme, faça o cadastro do filme.");
            }

            int oscarFilme = filmeRecebido.QtdOscars;
            string nomeFilme = filmeRecebido.Titulo;
            if (string.IsNullOrEmpty(nomeFilme))
            {
                return BadRequest("Nome do filme não informado.");
            }

            Filme filmeCriado = _gestaoServices.CadastrarFilme(filmeRecebido);
            return Created("filme", filmeRecebido); // vai retornar status 201
        }
    }
}
