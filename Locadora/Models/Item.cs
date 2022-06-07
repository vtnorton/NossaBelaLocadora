using Locadora.Respository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Locadora.Models
{
    public class Item
    {
        public int Id { get; set; }

        public int Quantidade { get; set; }
        public int Valor { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public Item()
        {
            List<Item> itens = Armazenamento.Biblioteca;
            int quantidadeDeItens = 1000 + itens.Count;
            Id = quantidadeDeItens++;
        }
    }
}
