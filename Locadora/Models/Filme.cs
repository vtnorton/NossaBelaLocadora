using Locadora.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Models
{
    public class Filme : Item
    {
        private FilmeViewModel filmeRecebido;



        public Filme(FilmeViewModel filmeRecebido)
        {
            this.filmeRecebido = filmeRecebido;
        }
      
        public int Duracao { get; set; }
        public int QuantidadeDeOscars { get; set; }
        public Guid IdFilme { get; set; }

    }
}
