Console.WriteLine("## Métodos ##\n");

MinhaClasse minhaClasse = new MinhaClasse();
minhaClasse.Saudacao("Paulo", Convert.ToString(DateTime.Now));

Console.ReadKey();

public class MinhaClasse
{
    public void Saudacao(string nome, string data)
    {
        Console.WriteLine(nome);
        Console.WriteLine(data);
    }
}