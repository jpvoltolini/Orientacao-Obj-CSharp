
class ContaCorrente
{
    public string Numero;
    public decimal Saldo;

public void ImprimirInfo()=>
Console.WriteLine($"Conta nº {Numero} possui um saldo de: R${Saldo}.\n");

    public void Depositar(decimal valor)
    {
        Saldo += valor;
    }

}
