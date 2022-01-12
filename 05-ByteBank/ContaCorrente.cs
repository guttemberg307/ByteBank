
using _05_ByteBank;

namespace _05_ByteBank
{
    public class ContaCorrente
    {

        public Cliente titular; // titular faz referencia ao objeto Cliente
        public int agencia;
        public int numero;
        public double saldo = 100; // --> valor padrão


        public bool Sacar(double valor) // -- metodo Sacar 
        {
            if (this.saldo < valor)
            {
                return false;
            }
            this.saldo -= valor;
            return true;

        }

        public void Depositar(double valor) // --- usamos VOID quando o metodo nao retorna nada

        {
            this.saldo += valor; // recebe o valor e acrescenta no saldo
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)// contaDestino é a instancia de contaCorrente
        {
            if (this.saldo < valor) // se o saldo for menor 
            {
                return false;  // return sempre para quando a condição for verdade
            }
            this.saldo -= valor;// subtrai o valor 
            contaDestino.Depositar(valor);// acrescenta o valor
            return true;
        }

    }
}