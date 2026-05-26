using _23PartialClass;

Console.WriteLine("## Partial Class ##\n");

MinhaPartialClass minhaPartialClass = new MinhaPartialClass();

Console.WriteLine("Idade para nascidos em: 07/08/2003\n");
var idade = minhaPartialClass.CalculaIdade(new DateTime(2003, 8, 7));
Console.WriteLine($"{Math.Round(idade.TotalDays / 365)} anos");

Console.ReadKey();