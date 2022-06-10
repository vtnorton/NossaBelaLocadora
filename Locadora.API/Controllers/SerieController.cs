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
    [Route("serie")] // Alterado api/serie para serie
    public class SerieController : BibliotecaController
    {
        private GestaoServices _gestaoServices;
        public SerieController()
        {
            _gestaoServices = new GestaoServices();
        }

        [HttpPost] // POST da api/serie
        public ActionResult CadastrarSerie(
            [FromBody] SerieViewModel serieRecebido)
        {
            if (serieRecebido == null)
            {
                return BadRequest("Nenhuma série cadastrada. Faça o cadastro de uma série.");
            }

            int tempSerie = serieRecebido.Temporadas;
            string nomeSerie = serieRecebido.Titulo;
            if (string.IsNullOrEmpty(nomeSerie))
            {
                return BadRequest("Nome da série não informado.");
            }

            _gestaoServices.CadastrarSerie(serieRecebido);
            return Created("serie", serieRecebido);
        }

        public List<Serie> ListarSeries()
        {
            // Armazenamento vai precisar colocar o
            // using AulasPCDev.Respository;
            // no inicio do código
            // Ctrl + . é um atalho para adicionar esse using.

            List<Serie> listaSeries =
                Armazenamento.Series;
            return listaSeries;
        }
    }
}
