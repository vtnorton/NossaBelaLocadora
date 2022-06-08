using Locadora.Models;
using Locadora.Respository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Services
{
    class FuncoesServiços
    {
        private List<Item> _biblioteca = Armazenamento.Biblioteca;


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

        public void CadastrarSerie()
        {
            Serie serie = new Serie();

            Console.WriteLine("Qual o nome da série que deseja cadastrar?");
            serie.Titulo = Console.ReadLine();

            Console.WriteLine("Quantos cópias desta série existem?");
            serie.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor da locação deste séries?");
            serie.Valor = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantas temporadas tem esta série?");
            serie.Temporadas = int.Parse(Console.ReadLine());

            _biblioteca.Add(serie);
        }
    }
}
