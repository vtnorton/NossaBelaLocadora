using Locadora.Models;
using Locadora.Respository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Services
{
    // trabalhar com a lista filmes e séries
    // trabalhar com a lista de usuários
    public class LocacaoService
    {
        public Item CadastrarSerie(SerieViewModel serieRecebida)
        {
            Item serie = new Item();
            Armazenamento.Biblioteca.Add(serieRecebida);
            return serie;
        }

    }
}
