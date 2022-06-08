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
        public Serie CadastrarSeries(SerieViewModel serieRecebido)
        {
            Serie serie = new Serie(serieRecebido);


            Armazenamento.Serie.Add(serie);
            
            return serie;
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


        public List<Serie> ListarSeries()
        {
            throw new NotImplementedException();
        }
    }
}
