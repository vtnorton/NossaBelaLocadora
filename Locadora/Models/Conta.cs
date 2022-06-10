using System;
using System.ComponentModel.DataAnnotations;

namespace Locadora.Models
{
    public class Conta
    {
        [Key]
        public int Id { get; set; }
        public int Saldo { get; private set; }


        public string ToString()
        {
            return "R$ " + Saldo + ",00";
        }
        public Conta()
        {           

        }
        public Conta(int saldoInicial)
        {
            Saldo = saldoInicial;
        }

      
        public void Deposito(int valor)
        {
            Saldo = Saldo + valor;
        }
        public void Saque(int valor)
        {
            Saldo = Saldo - valor;
        }
    }
}
