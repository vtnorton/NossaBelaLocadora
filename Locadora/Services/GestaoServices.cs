using Locadora.Models;
using Locadora.Repository;
using Locadora.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Services
{
    public class GestaoServices
    {
        // removido Armazenamento.Biblioteca para gerar 2 Listas de Filmes e Séries
        private List<Filme> _listaFilmes = Armazenamento.Filmes;
        private List<Serie> _listaSeries = Armazenamento.Series;

        public List<object> ListarItens()
        {
            List<object> listaItens = new List<object>();

            listaItens.AddRange(_listaSeries);
            listaItens.AddRange(_listaFilmes);
            return listaItens;
        }

        public Filme CadastrarFilme(FilmeViewModel filmeRecebido)
        {
            Filme filme = new Filme(filmeRecebido);

            filme.Titulo = filmeRecebido.Titulo;
            filme.Descricao = filmeRecebido.Descricao;
            filme.Duracao = filmeRecebido.Duracao;
            filme.qtdOscars = filmeRecebido.QtdOscars;
            filme.Quantidade = filmeRecebido.Quantidade;
            filme.Valor = filmeRecebido.Valor;

            _listaFilmes.Add(filme);
            return filme;
        }

        public Serie CadastrarSerie(SerieViewModel serieRecebido)
        {
            Serie serie = new Serie(serieRecebido);

            serie.Titulo = serieRecebido.Titulo;
            serie.Descricao = serieRecebido.Descricao;
            serie.Temporadas = serieRecebido.Temporadas;
            serie.Emmies = serieRecebido.Emmies;
            serie.Quantidade = serieRecebido.Quantidade;
            serie.Valor = serieRecebido.Valor;

            _listaSeries.Add(serie);
            return serie;
        }
    }
}
