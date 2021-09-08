using System;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente(); // aqui é criada uma nova instância(objeto)

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("//////////////////////////////////////");
            contaDaGabriela.titular = "Gabriela"; //  contaDaGabriela APONTA para titular, onde ContaCorrente está guardando um espaço na memoria para o nome Grabriela 
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;
            contaDaGabriela.saldo = 100;

            Console.WriteLine("Nome: " + contaDaGabriela.titular);
            Console.WriteLine("Agência: " + contaDaGabriela.agencia);
            Console.WriteLine("Número: " + contaDaGabriela.numero);
            Console.WriteLine("Saldo: " + contaDaGabriela.saldo);


            contaDaGabriela.saldo += 200;// faz a soma de mais 200 para o saldo
            Console.WriteLine("Saldo: " + contaDaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
