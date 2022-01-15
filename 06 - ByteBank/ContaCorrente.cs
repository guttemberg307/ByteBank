
//using _05_ByteBank;

namespace _06_ByteBank
{
    public class ContaCorrente
    {

        public Cliente titular; 
        public int agencia;
        public int numero;
        private double saldo = 100; // --> valor padrão


        public void DefinirSaldo(double saldo)
        {
           if(saldo < 0) //--> se o saldo for negativo nao vai retornar valor algum 
            {
                return;
            }
              this.saldo = saldo;  //--> retornona o valor atual caso seja positivo 
        }

        public double ObterSaldo()
        {
            return saldo; //--> somente obtem o saldo atual da conta 
        }


        public bool Sacar(double valor) 
        {
            if (saldo < valor)
            {
                return false;
            }
            this.saldo -= valor;
            return true;

        }

        public void Depositar(double valor) 

        {
            saldo += valor; 
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (saldo < valor) 
            {
                return false; 
            }
            saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }

    }
}