using Locadora.Models;
using Locadora.Respository;
using Locadora.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Locadora.Services
{
    public class SerieServices
    {
        public Serie CadastrarSeries(SerieViewModel serieRecebida)
        {
            Serie serie = new Serie(serieRecebida);
            serie.Titulo = serieRecebida.NomeDaSerie;


            Armazenamento.Series.Add(serie);
            
            return serie;
        }

        public List<Serie> ListarSeries()
        {
            return Armazenamento.Series;
        }
        public Serie ObterSerie(string idRecebido)
        {
            List<Serie> lista = ListarSeries();
            if (lista.Any(f => f.Id.ToString() == idRecebido))
            {
                Serie serie = lista.Where(u => u.Id.ToString() == idRecebido).First();
                return serie;
            }
            return null;
        }

    }
}
