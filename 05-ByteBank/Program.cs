using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente Gabriela = new Cliente();// nova instancia de Cliente 

            Gabriela.nome = "Gabriela"; // Gabriela aponta para as propriedades de do cliente 
            Gabriela.profissao = "Desenvolveroa c#";
            Gabriela.cpf = "434.562.878-20";
       
        
            ContaCorrente conta = new ContaCorrente(); // nova instancia de conta 

            conta.titular = Gabriela; // titular usa como referencia a Gabriela (tudo o que a Gabriela tem , Titular pega com referencia)
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634527;


            Console.WriteLine(conta.titular);

            conta.titular.nome = "Garbriela Costa"; // substitui o nome Gabriela por Gabriela costa 

            Console.WriteLine(Gabriela.nome); // recebe novo nome Gabriela Costa 
            Console.WriteLine(conta.titular.nome); // recebe novo nome Gabriela Costa , pois tudo o que for de referencia da Gabriela , titular tambem tem.
            Console.WriteLine(conta.titular.profissao);
            Console.WriteLine(conta.titular.cpf);
            Console.ReadLine();
        }
    }
}
