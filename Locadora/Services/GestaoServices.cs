using Locadora.Models;
using Locadora.Respository;
using Locadora.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Locadora.Services
{
    public class GestaoServices
    {
        private List<Filme> _filmes = Armazenamento.Filmes;
        private List<Serie> _series = Armazenamento.Series;
        private SerieViewModel serieRecebida;
        private FilmeViewModel filmeRecebido;

        public List<object> ListarItens()
        {
            List<object> listaRetornada = new List<object>();

            listaRetornada.AddRange(_filmes);
            listaRetornada.AddRange(_series);
            return listaRetornada;
        }

        public Filme CadastrarFilme(FilmeViewModel filmeRecebido)
        {
            Filme filme = new Filme();
            filme.Titulo = filmeRecebido.Titulo;
            filme.Descricao=filmeRecebido.Descricao;
            filme.QuantidadeDeOscars = filmeRecebido.Oscars;
            filme.Duracao = filmeRecebido.Duracao;
            filme.Valor = filmeRecebido.Valor;
            filme.Quantidade = filmeRecebido.Quantidade;
            

            _filmes.Add(filme);
            return filme;
        }

        public Serie CadastrarSerie(SerieViewModel serieRecebida)
        {
            Serie serie = new Serie();
            serie.Descricao = serieRecebida.Descricao;
            serie.Quantidade= serieRecebida.Quantidade;
            serie.Emmies = serieRecebida.Emmys;
            serie.Titulo= serieRecebida.Titulo;
            serie.Valor= serieRecebida.Valor;
            serie.Temporadas = serieRecebida.Temporadas;
            
            

            _series.Add(serie);
            return serie;
        }
       
    }
}
