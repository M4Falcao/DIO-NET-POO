using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO_NET_POO.Models
{
    public abstract class Conta
    {
        protected decimal Saldo { get; set; }
        public abstract void Creditar(decimal valor);

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo atual é de {Saldo:C}");
        }
    }
}