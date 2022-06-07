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
        private List<Item> _biblioteca = Armazenamento.Biblioteca;
        private SerieViewModel serieRecebida;
        private FilmeViewModel filmeRecebido;

        public void Cadastrar()
        {
            Console.WriteLine("O que deseja cadastrar?");
            Console.WriteLine("1 - Filme");
            Console.WriteLine("2 - Série");
            Console.WriteLine("Qualquer outro número para voltar");

            int respotas = int.Parse(Console.ReadLine());
            if (respotas == 1)
            {
                CadastrarFilme(filmeRecebido);
            }
            if (respotas == 2)
            {
                CadastrarSerie(serieRecebida);
            }
        }

        public Item CadastrarFilme(FilmeViewModel filmeRecebido)
        {
            Filme filme = new Filme();
            filme.Titulo = filmeRecebido.Titulo;
            filme.Descricao=filmeRecebido.Descricao;
            filme.QuantidadeDeOscars = filmeRecebido.Oscars;
            filme.Duracao = filmeRecebido.Duracao;
            filme.Valor = filmeRecebido.Valor;
            

            _biblioteca.Add(filme);
            return filme;
        }

        public Item CadastrarSerie(SerieViewModel serieRecebida)
        {
            Serie serie = new Serie();
            serie.Descricao = serieRecebida.Descricao;
            serie.Quantidade= serieRecebida.Quantidade;
            serie.Emmies = serieRecebida.Emmys;
            serie.Titulo= serieRecebida.Titulo;
            serie.Valor= serieRecebida.Valor;
            

            _biblioteca.Add(serie);
            return serie;
        }
    }
}
