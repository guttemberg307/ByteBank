
public class ContaCorrente
{
    public string titular;
    public int  agencia;
    public int numero;
    public double saldo = 100; // --> valor padrão


    public bool Sacar(double valor) // -- metodo Sacar 
    {
        if (this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            return true; 
        }
    }

    public void Depositar(double valor) // --- usamos VOID quando o metodo nao retorna nada

    {
        this.saldo += valor; // recebe o valor e acrescenta no saldo
    }


}