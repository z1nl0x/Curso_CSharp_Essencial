Console.WriteLine("## Herança Sealed ##\n");

Cliente cliente = new();
// cliente.Nome = "Paulo";
cliente.ExibeNome();

Console.ReadKey();


// O Modificador seadled impede que a classe seja herdada
sealed class Pessoa
{
    public string? Nome { get; set; }

    public void ExibeNome()
    {
        Console.WriteLine($"Meu nome é {Nome}");
    }
}

class Cliente
{
    public new void ExibeNome()
    {
        // Console.WriteLine($"\nNome do cliente : {Nome}");
    }
}