using _16ConstrutorEstatico;

Console.WriteLine("## Construtor Estático ##\n");

Pessoa p1 = new(19, "Maria");
Console.WriteLine(p1.Nome + " - " + p1.Idade);
Console.WriteLine("Idade Minima " + Pessoa.IdadeMinima);

Pessoa p2 = new(20, "Manoel");
Console.WriteLine(p2.Nome + " - " + p2.Idade);
Console.WriteLine("Idade Minima " + Pessoa.IdadeMinima);

Console.ReadKey();

