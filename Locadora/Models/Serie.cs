using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Models
{
    public class Serie : Item
    {
        private object serieRecebida;

        public Serie(object serieRecebida)
        {
            this.serieRecebida = serieRecebida;
        }

        public int Temporadas { get; set; }
        public int Emmies { get; set; }
    }
}
