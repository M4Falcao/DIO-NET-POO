using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIO_NET_POO.Interfaces;

namespace DIO_NET_POO.Models
{
    public class Calculadora : ICalculadora
    {
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Subtrair(int num1, int num2)
        {
            return num1 + num2;

        }
        // public int Dividir(int num1, int num2)
        // {
        //     return num1 + num2;

        // }
        public int Multiplicar(int num1, int num2)
        {
            return num1 + num2;

        }


    }
}