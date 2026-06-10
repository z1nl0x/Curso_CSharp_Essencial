Console.WriteLine("## Interfaces ##\n");

IControle d = new Demo();

Console.ReadKey();

interface IControle
{
    public string Nome { get; set; }
    void Desenhar();

    public void Exibir()
    {
        Console.WriteLine("Teste...");
    }
}

interface IGrafico
{
    void Pintar();
}

public class Demo : IControle, IGrafico
{
    public string Nome { get; set; } = string.Empty;
    public void Desenhar()
    {
        Console.WriteLine("Desenhando...");
    }

    public void Pintar()
    {
        Console.WriteLine("Pintando...");
    }
}