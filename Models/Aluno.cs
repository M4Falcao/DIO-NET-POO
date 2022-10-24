using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO_NET_POO.Models
{
    public class Aluno : Pessoa
    {
        public Aluno(string nome, int idade) : base(nome, idade)
        {

        }
        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá! Me chamo {Nome} e tenho nota {Nota:F}");
        }
    }
}