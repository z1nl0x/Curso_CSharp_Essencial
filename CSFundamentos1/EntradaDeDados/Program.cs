Console.WriteLine("\n ## Entrada de Dados ##");

Console.WriteLine("\nInforme seu nome");
string nome = Console.ReadLine();
Console.WriteLine($"\nO seu nome é: {nome}");
Console.WriteLine("\nO seu nome é: " + nome);
Console.WriteLine();

Console.WriteLine("\nInforme a sua idade");
int idade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\nA sua idade é " + idade + " anos");
Console.WriteLine($"\nA sua idade é {idade} anos");

Console.ReadKey();