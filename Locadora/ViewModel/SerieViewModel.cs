using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Locadora.ViewModel
{
    public class SerieViewModel //classe que vamos receber parametros do usuario
    {
        [Required(ErrorMessage = "O campo título é obrigatório")]
        public string Titulo { get; set; }
        public int Temporadas { get; set; }
        public int Emmys { get; set; }
        public int Quantidade { get; set; }
        public int Valor { get; set; }
        public string Descricao { get; set; }
    }
}
