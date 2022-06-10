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
        public List<Item> _biblioteca = Armazenamento.Biblioteca;

        public FilmeViewModel filmeRecebido { get; set; }
        public SerieViewModel serieRecebida { get; set; }

        public void Cadastrar()
        {
            Console.WriteLine("O que deseja cadastrar?");
            Console.WriteLine("1 - Filme");
            Console.WriteLine("2 - Série");
            Console.WriteLine("Qualquer outro número para voltar");

            int respotas = int.Parse(Console.ReadLine());
            if (respotas == 1)
            {
               // CadastrarFilme();
            }
            if (respotas == 2)
            {
                //CadastrarSerie();
            }
        }

        public void CadastrarFilme()
        {
            Filme filme = new Filme(filmeRecebido);
            filme.Titulo = filmeRecebido.Titulo;
            filme.Quantidade = filmeRecebido.Quantidade;

                _biblioteca.Add(filme);
        }

        public void CadastrarSerie()
        {
            Serie serie = new Serie(serieRecebida);
            serie.Titulo = serieRecebida.Titulo;
            serie.Quantidade = serieRecebida.QuantidadeDETemporadas;
            


            _biblioteca.Add(serie);
        }
    }
}
