using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Gabriela";

            Console.WriteLine(conta.titular);
            Console.WriteLine(conta.agencia);//----> vai imprimir um valor padrão "Zero"
            Console.WriteLine(conta.saldo);//----> vai imprimir um valor padrão "CEM" que já foi atribuido a classe ContaCorrente.cs

            Console.ReadLine();

            Console.WriteLine();
        }
    }
}
