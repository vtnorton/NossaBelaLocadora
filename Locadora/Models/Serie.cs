using Locadora.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Models
{
    public class Serie : Item
    {
        public Guid IdSerie { set; get; } // GUID serve para criar ID de série
        public int Temporadas { get; set; }
        public int Emmies { get; set; }

        private SerieViewModel serieRecebido;
        public Serie(SerieViewModel serieRecebido)
        {
            Temporadas = serieRecebido.Temporadas;
            Emmies = serieRecebido.Emmies;
            IdSerie = Guid.NewGuid();
        }
    }
}
