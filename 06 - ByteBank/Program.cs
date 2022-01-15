using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
     class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente();

            Cliente cliente = new Cliente();

            cliente.Nome = "Guilherme";
            cliente.CPF = "434.564.879-20";
            cliente.Profissao = "Desenvolvedor";

            conta.Saldo = -10; // --> infere a regra de negocio, por ser negativo nao retorna valor algum 
            conta.Titular = cliente; // titular recebe os atributos de cliente 
           
            Console.WriteLine(conta.Saldo);
            Console.WriteLine(conta.Titular.Nome);// nome é um atributo de cliente 

            Console.ReadLine();
        }
    }
}
