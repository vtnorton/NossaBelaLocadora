using Locadora.Repository;
using Locadora.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Models
{
    public class Item
    {
        public Guid IdItem { get; set; } // Gera ID para os itens (filmes e séries)
        public int Quantidade { get; set; }
        public int Valor { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }

        public Item()
        {
            // o código tem que ser único
            // olhar a minha biblioteca
            // pegar a quantidade de itens
            // fazer um incremento na quantidade de itens da minha biblioteca

            IdItem = Guid.NewGuid();
        }
    }
}
