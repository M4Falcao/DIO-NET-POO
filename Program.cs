using DIO_NET_POO.Models;
////////////////////////////////////////////// Abstração ////////////////////////////////////////////
///Abstrai um objeto do mundo real para um vcontexto especifico, considerando apenas os atributos importantes
//Ex: Classe pessoa -> é a abstração

// Pessoa p1 = new Pessoa("Mateus", 23); //Objeto ->  a concretização da classe
// p1.Apresentar();



////////////////////////////////////////////// Encapsulamento ////////////////////////////////////////////
//Serve para protejer uma classe e definir limites para alterações de suas propriedades
//Saldo

// ContaCorrente c1 = new ContaCorrente(123, 200.00M);
// c1.Sacar(100);



////////////////////////////////////////////// Herança ////////////////////////////////////////////
///Nos premite reutilizar atributos, métodos e comportamentos de uma classe em outras classes
///Server para agrupr tipos parecidos, mas com propriedades unicas
///Pessoa ---->Aluno
///     \----->Professor
///public class ClasseFilha : ClassePai {}
//Só pode herdar de uma por vez

// Aluno a1 = new Aluno();
// a1.Nome = "ALuno 1";
// a1.Idade = 12;
// a1.Nota = 9.4F;
// a1.Apresentar();


////////////////////////////////////////////// Polimorfismo ////////////////////////////////////////////
///Sobrescrever metodos das classes filhas para que se comportem de maneira diferente
///O metodo da filha sobrescreve o metodo herdado
///public virtual void Apresentar(){} --> PAI
///public override void Apresentar(){} --> FILHA
///
/// Polimorfismo em tempo de compilação: Qaundo tem dois metodos com mesmo nome e parametros diferentes

// Professor p1 = new Professor();
// p1.Nome = "Euvlides";
// p1.Idade = 20;
// p1.Salario = 3143.64M;
// p1.Apresentar();

////////////////////////////////////////////// Classe abstrata ////////////////////////////////////////////
///Exclusivamente um modelo para ser herdado, NÂO pode ser instanciada
///<<abstract>>
///public abstract class Conta()
///protected -> Protegido com escessão de suas classes filhas
///public abstract void Creditar(decimal valor); --> Metodo abstrato, todas as filhas são ogrigadas a implementar

// ContaCorrente c1 = new ContaCorrente(123, 31298.32M);
// c1.ExibirSaldo();

// public Professor(string nome, int idade) : base(nome, idade) { }
// Aluno a1 = new Aluno("Mateus", 32);

////////////////////////////////////////////// Classe selada ////////////////////////////////////////////
///Nenhuma classe pode ser herança dela
///Metodo selado ninguem pode dar um override nele
///<<sealed>>
///public sealed class Professor : Pessoa

////////////////////////////////////////////// Classe object ////////////////////////////////////////////
///Mãe de todas as classse
///Todas as classes criadas derivam dela
///Prover serviços de baixo nivel na classe filha
///Ex: ToString(), GetType()...

// Computador c = new Computador();
// Console.WriteLine(c.ToString());


////////////////////////////////////////////// Interface ////////////////////////////////////////////
///É um contrato que pode ser implementado por uma classe, é como se fosse uma classe abstrata
///Os metodos podem ou não ser implementados na interface
///Obriga as classes a implementarem algo
///Uma classe pode implementar varias interfaces

Calculadora c = new Calculadora();
Console.WriteLine(c.Somar(3, 5));