using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO_NET_POO.Models
{
    // + numero
    // - saldo
    public class ContaCorrente : Conta
    {
        public ContaCorrente(int num, decimal saldoInit)
        {
            Numero = num;
            Saldo = saldoInit;
        }
        public int Numero { get; set; }
        //private decimal Saldo { get; set; }

        /// <summary>
        /// Saca caso o valor estiver disponivel em conta
        /// </summary>
        /// <param name="valor"></param>
        /// <exception cref="Exception"></exception>
        public void Sacar(decimal valor)
        {
            if (Saldo > valor)
            {
                Saldo -= valor;
            }
            else
            {
                throw new Exception("Saldo insuficiente");
            }
            ExibirSaldo();
        }
        public override void Creditar(decimal valor)
        {
            Saldo += valor;
        }

    }
}