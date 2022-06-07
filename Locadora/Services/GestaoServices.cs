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

        public void Cadastrar()
        {
            Console.WriteLine("O que deseja cadastrar?");
            Console.WriteLine("1 - Filme");
            Console.WriteLine("2 - Série");
            Console.WriteLine("Qualquer outro número para voltar");

            int respotas = int.Parse(Console.ReadLine());
            if (respotas == 1)
            {
                CadastrarFilme();
            }
            if (respotas == 2)
            {
                CadastrarSerie(serieRecebida);
            }
        }

        public void CadastrarFilme()
        {
            Filme filme = new Filme();

            Console.WriteLine("Qual o nome do filme que deseja cadastrar?");
            filme.Titulo = Console.ReadLine();

            Console.WriteLine("Quantos fitas deste filme existem?");
            filme.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor da locação deste filme?");
            filme.Valor = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a duração do filme?");
            filme.Duracao = int.Parse(Console.ReadLine());

            _biblioteca.Add(filme);
        }

        public void CadastrarSerie(SerieViewModel serieRecebida)
        {
            Serie serie = new Serie();
            serie.Descricao = serieRecebida.Descricao;
            serie.Quantidade= serieRecebida.Quantidade;
            serie.Emmies = serieRecebida.Emmys;
            serie.Titulo= serieRecebida.Titulo;
            serie.Valor= serieRecebida.Valor;
            

            _biblioteca.Add(serie);
        }
    }
}
