Console.WriteLine("## Herança Virtual Override ##\n");

var gato = new Gato() { Nome = "FelinoCrazy" };
gato.ExibeNome();

Console.ReadKey();

class Animal
{
    public string? Nome { get; set; }

    public virtual void ExibeNome()
    {
        Console.WriteLine($"\nMeu nome é {Nome}");
    }
}

class Gato: Animal
{
    public override void ExibeNome()
    {
        Console.WriteLine($"\nEu sou um gato. Meu nome é:  {Nome}");
    }
}

class Cachorro : Animal
{
    public virtual void ExibeNome()
    {
        Console.WriteLine($"\nMeu nome é {Nome}");
    }
}