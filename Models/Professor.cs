using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO_NET_POO.Models
{
    public sealed class Professor : Pessoa
    {
        public Professor(string nome, int idade) : base(nome, idade) { }
        public decimal Salario { get; set; }
    }
}