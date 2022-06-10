using Locadora.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Models
{
    public class Filme : Item
    {
        public Guid IdFilme { get; set; } // GUID serve para criar ID de filme
        public int Duracao { get; set; }
        public int qtdOscars { get; set; }

        private FilmeViewModel filmeRecebido;
        public Filme(FilmeViewModel filmeRecebido)
        {
            Duracao = filmeRecebido.Duracao;
            qtdOscars = filmeRecebido.QtdOscars;
            IdFilme = Guid.NewGuid();
        }
    }
}
