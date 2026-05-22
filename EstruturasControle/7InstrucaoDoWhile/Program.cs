Console.WriteLine("## Instrução Do While ##\n");

var i = 1;

do
{
    Console.WriteLine($"i = {i}");
    i++;

    if (i > 7)
    {
        break;
    }
} while(i <= 10);

Console.WriteLine("\nFim do processamento!");
Console.ReadKey();