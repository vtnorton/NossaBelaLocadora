using Locadora.Models;
using Locadora.Respository;
using Locadora.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Services
{
    public class GestaoServices
    {
        private List<Filme> _listaFilmes = 
            Armazenamento.Filmes;

        private List<Serie> _listaSeries =
            Armazenamento.Series;

        public Filme CadastrarFilme(FilmeViewModel filmeRecebido)
        {
            Filme filme = new Filme(filmeRecebido);

            filme.Titulo = filmeRecebido.Titulo;
            filme.Duracao = filmeRecebido.Duracao;
            filme.Descricao = filmeRecebido.Descricao;
            filme.QuantidadeDeOscars = filmeRecebido.QuantidadeDeOscars;
            filme.Quantidade = filmeRecebido.Quantidade;
            filme.Valor = filmeRecebido.Valor;
            
            _listaFilmes.Add(filme);

            return filme;
        }
        public Serie CadastrarSerie(SerieViewModel serieRecebida)
        {
            Serie serie = new Serie();
            serie.Titulo = serieRecebida.Titulo;
            serie.Descricao = serieRecebida.Descricao;
            serie.Valor = serieRecebida.Valor;
            serie.Temporadas = serieRecebida.Temporadas;

            _listaSeries.Add(serie);

            return serie;
        }

        public List<object> ListarItens()
        {
            List<object> nomeQualquer = 
                new List<object>();

            nomeQualquer.AddRange(_listaFilmes);
            nomeQualquer.AddRange(_listaSeries);

            return nomeQualquer;
        }
    }
}
