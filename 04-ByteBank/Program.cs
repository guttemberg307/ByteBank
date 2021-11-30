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
            ContaCorrente minhaConta = new ContaCorrente(); //--> nova instancia de contacorrente --> minhaconta

            minhaConta.titular = "Gutemberg";
        

            Console.WriteLine(minhaConta.saldo);
          
            bool resultatoSaquee = minhaConta.Sacar(500);
            
        
            Console.WriteLine(resultatoSaquee);
            Console.WriteLine(minhaConta.saldo);

            minhaConta.Depositar(500);
            Console.WriteLine(minhaConta.saldo);

            Console.ReadLine();
        }
    }
}
