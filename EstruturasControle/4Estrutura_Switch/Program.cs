Console.WriteLine("## Estrutura Switch ##\n");

Console.WriteLine("Valor da Compra R$ 600,00\n");
Console.WriteLine("Informe o no. de parcelas (1 a 3)\t");
var numeroParcelas = Convert.ToInt32(Console.ReadLine());

switch (numeroParcelas)
{
    case 1:
        Console.WriteLine($"\nPrestação R$ {600/numeroParcelas}");
        break;
    case 2:
        Console.WriteLine($"\nPrestação R$ {600/numeroParcelas}");
        break;
    case 3:
        Console.WriteLine($"\nPrestação R$ {600/numeroParcelas}");
        break;
}

Console.WriteLine("Fim do processamento!");
Console.ReadKey();