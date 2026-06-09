using _7Heranca_Exercicio1;

Console.WriteLine("## Herança Exercicio 1 ##\n");

Console.WriteLine("\nConta Corrente: Número: 111 Titular: Paulo");
Conta conta = new();
conta.Numero = 111;
conta.Titular = "Paulo";

Console.WriteLine("Depositando R$ 1000.00");
conta.Depositar(1000);
Console.WriteLine("Sacando R$ 100.00");
conta.Sacar(100);
Console.WriteLine("Saldo: R$ " + conta.Saldo.ToString("C"));

Console.WriteLine("Sacando R$ 2000.00");
conta.Sacar(2000);
Console.WriteLine("Saldo: R$ " + conta.Saldo.ToString("C"));

Console.WriteLine("\nConta Poupança: Número: 222 Titular: Pedro");
ContaPoupanca contaPoupanca = new();
contaPoupanca.Numero = 222;
contaPoupanca.Titular = "Pedro";

Console.WriteLine("Depositando R$ 1000.00");
contaPoupanca.Depositar(1000);

Console.WriteLine("Sacando R$ 100.00");
contaPoupanca.Sacar(100);
Console.WriteLine("Saldo da Conta Poupança: R$ " + contaPoupanca.Saldo.ToString("C"));

Console.WriteLine("Sacando R$ 2000.00");
contaPoupanca.Sacar(2000);
Console.WriteLine("Saldo da Conta Poupança: R$ " + contaPoupanca.Saldo.ToString("C"));



Console.WriteLine("\nConta Investimento: Número: 333 Titular: Ana");
ContaInvestimento contaInvestimento = new();
contaInvestimento.Numero = 333;
contaInvestimento.Titular = "Ana";

Console.WriteLine("Depositando R$ 1000.00");
contaInvestimento.Depositar(1000);

Console.WriteLine("Sacando R$ 100.00");
contaInvestimento.Sacar(100);
Console.WriteLine("Saldo da Conta Investimento: R$ " + contaInvestimento.Saldo.ToString("C"));

Console.WriteLine("Sacando R$ 2000.00");
contaInvestimento.Sacar(2000);
Console.WriteLine("Saldo da Conta Investimento: R$ " + contaInvestimento.Saldo.ToString("C"));

Console.ReadKey();