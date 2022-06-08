using Locadora.Models;
using Locadora.Respository;
using System;
using System.Collections.Generic;
using System.Text;
using Locadora.Services;


namespace Locadora.Services
{
    
    public class GestaoServices
    {

        FuncoesServiços funcoesServiços = new FuncoesServiços();
        public void Cadastrar()
        {
            Console.WriteLine("O que deseja cadastrar?");
            Console.WriteLine("1 - Filme");
            Console.WriteLine("2 - Série");
            Console.WriteLine("Qualquer outro número para voltar");

            int respotas = int.Parse(Console.ReadLine());

            if (respotas == 1)
            {
               funcoesServiços.CadastrarFilme();
            }
            if (respotas == 2)
            {
               funcoesServiços.CadastrarSerie();
            }
        }

        
    }
}
