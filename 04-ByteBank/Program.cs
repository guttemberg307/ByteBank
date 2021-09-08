using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente minhaConta = new ContaCorrente();

            minhaConta.titular = "Gutemberg";
        

            Console.WriteLine(minhaConta.saldo);
            minhaConta.Sacar(50);
            Console.WriteLine(minhaConta.saldo);
            
            bool resultatoSaque = minhaConta.Sacar(50);
            bool resultatoSaquee = minhaConta.Sacar(500);
            
            Console.WriteLine(resultatoSaque);
            Console.WriteLine(resultatoSaquee);            

            Console.ReadLine();
        }
    }
}
