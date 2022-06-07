using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Locadora.ViewModel
{
    public class FilmeViewModel
    {
        [Required(ErrorMessage = "O campo título é obrigatório")] 
        public string Titulo { get; set; }
        public int Duracao { get; set; }
        public int Oscars { get; set; }
        public int Quantidade { get; set; }
        public int Valor { get; set; }
        public string Descricao { get; set; }
    }
}
