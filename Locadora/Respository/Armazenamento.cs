using Locadora.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Respository
{
    public class Armazenamento
    {
        public static List<Usuario> Usuarios = new List<Usuario>();

        public static List<Serie> Series = new List<Serie>(); //é preciso criar listas separadas de itens p/ obtermos todas as infos da classe

        public static List<Filme> Filmes = new List<Filme>();
    }
}
