Console.WriteLine("## Instrução If ##\n");

Console.WriteLine("Cliente Especial (true/false)");
var resposta = Convert.ToBoolean(Console.ReadLine());

if (resposta)
{
    Console.WriteLine("Desconto de 10%");
}
Console.WriteLine("Fim do processamento!");
Console.ReadKey();