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

            ContaCorrente contaDaGabriela = new ContaCorrente();



            // conta antes da transferencia 
            Console.WriteLine("Saldo da minhaConta: " + minhaConta.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);


            //Gabriela recebe o valor de 200
            bool resultatoTransferencia = minhaConta.Transferir(200, contaDaGabriela);
            Console.WriteLine(resultatoTransferencia);

            // conta depois da transferencia
            Console.WriteLine("Saldo da minhaConta: " + minhaConta.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);


            contaDaGabriela.Transferir(100, minhaConta);

            Console.WriteLine("Saldo da minhaConta: " + minhaConta.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);


            Console.ReadLine();
        }
    }
}
