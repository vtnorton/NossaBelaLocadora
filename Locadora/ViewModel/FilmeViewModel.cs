using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.ViewModel
{
    public class FilmeViewModel
    {
        public Guid Id { get; set; }
        public Guid IdFilme { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Duracao { get; set; }
        public int QtdOscars { get; set; }
        public int Quantidade { get; set; }
        public int Valor { get; set; }
    }
}
