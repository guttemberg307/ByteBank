
//using _05_ByteBank;

namespace _06_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int agencia;
        public int numero;
        private double _saldo = 100; // --> valor padrão

        public double Saldo
        {
            get // faz o retorno do saldo
            {
                return _saldo;
            }
            set // defini o saldo 
            {                   // value quer dizer valor
                if (value < 0) //--> se o value for negativo nao vai retornar valor algum 
                {
                    return;
                }
                _saldo = value;  //--> retornona o value atual caso seja positivo 
            }
        }

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