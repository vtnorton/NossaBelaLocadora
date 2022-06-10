using Locadora.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Respository
{
    public class ApplicationDBContext : DbContext
        
    {
        public DbSet<Usuario> TabelaDeUsuario { get; set; }
        public DbSet<Filme> TabelaDeFilme { get; set; }
        public DbSet<Serie> TabelaDeSerie { get; set; }
        public DbSet<Conta> TabelaDeConta { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string de conexão
            //Sçao informações para se contectar com o BD
            //o servidor
            //forma de conectar (usuário/senha)
            
            string conexao = "Server=localhost\\SQLEXPRESS;Database=Locadora;Integrated Security=SSPI";
            optionsBuilder.UseSqlServer(conexao);
        }
    }
}
