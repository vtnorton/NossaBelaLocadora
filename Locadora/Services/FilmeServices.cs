using Locadora.Models;
using Locadora.Respository;
using Locadora.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Locadora.Services
{
    public class FilmeServices
    {
        // trabalhar com a lista filmes e séries
        public Filme CadastrarFilmes(FilmeViewModel filmeRecebido)
        {
            Filme filme = new Filme(filmeRecebido);
            Armazenamento.Filmes.Add(filme);

            return filme;
        }
       
        
        public Filme ObterFilme(string idRecebido)
        {
            List<Filme> lista = ListarFilmes();
            if (lista.Any(f => f.Id.ToString() == idRecebido))
            {
                Filme filme = lista.Where(u => u.Id.ToString() == idRecebido).First();
                return filme;
            }
            return null;
        }

        private List<Filme> ListarFilmes()
        {
            throw new NotImplementedException();
        }
    }
}