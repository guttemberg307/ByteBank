
//using _05_ByteBank;

namespace _07_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public static int TotalDeContasCriadas { get; private set; } // colocando private no set não vai ser permitido a alteração fora da classe da contacorrente

        public int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if(value <= 0)
                {
                    return;
                }
                _agencia = value;
            }
        }
        public int Numero { get; set; }

        private double _saldo = 100; // --> valor padrão

        public double Saldo
        {
            get 
            {
                return _saldo;
            }
            set 
            {                   
                if (value < 0)
                {
                    return;
                }
                _saldo = value; 
            }
        }

      public ContaCorrente(int agencia , int numero) //-- nesse contrutor é obrigatorio colocar numero e agencia 
       {
            Agencia = agencia;
            Numero = numero;

           TotalDeContasCriadas++; // não precisa colocar o nome da classe pq ja estamos dentro da classe conta corrente
       }                            // toda vez que for chamada vai ser acrescentado 1 

        public bool Sacar(double valor) 
        {
            if (_saldo < valor)
            {
                return false;
            }
            _saldo -= valor;
            return true;

        }

        public void Depositar(double valor) 

        {
            _saldo += valor; 
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor) 
            {
                return false; 
            }
            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }

    }
}