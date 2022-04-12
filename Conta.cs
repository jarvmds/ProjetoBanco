class Conta
{
    public int Codigo { get; set; }
    public double Saldo { get; private set; }


    public Conta(int codigo)
    {
        Codigo = codigo;
        Saldo = 0.0;
    }

    public void Sacar (double valor)
    {
        if (valor > Saldo)
        {
            throw new ArgumentException("Valor impossível de ser sacado");
        }

        Saldo = Saldo - valor;
    }

    public void Depositar (double valor)
    {
        if (valor < 1)
        {
            throw new ArgumentException("Impossível depositar valor negativo");
        }

        Saldo = Saldo + valor;
    }

    public void Transferir (double valor, Conta conta)
    {
        if (valor > Saldo)
        {
            throw new ArgumentException("Impossível transferir valor inferior ao saldo da conta");
        }

        Saldo = Saldo - valor;
        conta.Saldo = Saldo + valor;
    }
}