Conta c1 = new Conta(1);
Conta c2 = new Conta(2);

c1.Depositar(1000.00);
c1.Sacar(200.00);
Console.WriteLine("Saldo da conta 1 após depósito: " + c1.Saldo);

c2.Depositar(200.00);
c2.Sacar(150.00);
Console.WriteLine("Saldo da conta 2 após depósito: " + c2.Saldo);

c1.Transferir(150.00, c2);
Console.WriteLine("Saldo da conta 1 após transferência: " + c1.Saldo);

c2.Transferir(3350.00, c1);
Console.WriteLine("Saldo da conta 2 após transferência: " + c2.Saldo);