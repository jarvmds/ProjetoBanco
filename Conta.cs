class Conta
{
    public int Codigo { get; set; }
    public double Saldo { get; private set; }


    public Conta(int codigo, double valor)
    {
        Codigo = codigo;
        Saldo = 0.0;
        VerificarSaldo(valor);
    }

    public void Sacar (double valor)
    {
        if (valor > Saldo)
        {
            throw new ArgumentException("Valor impossível de ser sacado");
        }

        Saldo = Saldo - valor;
        ValidarValor(valor);
    }

    public void Depositar (double valor)
    {
        ValidarValor(valor);

        Saldo = Saldo + valor;
    }

    public void Transferir (double valor, Conta conta)
    {
        if (valor > Saldo)
        {
            throw new ArgumentException("Impossível transferir valor inferior ao saldo da conta");
        }

        Saldo = Saldo - valor;
        conta.Saldo = conta.Saldo + valor;
        ValidarValor(valor);
        VerificarSaldo(valor);
    }

    public void ValidarValor (double valor)
    {
        if (valor <= 0) throw new ArgumentException("Valor deve ser maior que zero");
    }

    private void VerificarSaldo(double valor)
    {
        if (valor > Saldo) throw new ArgumentException("");
    }
}