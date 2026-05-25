Console.WriteLine("## Métodos ##\n");

MinhaClasse minhaClasse = new MinhaClasse();
minhaClasse.Saudacao();

Console.ReadKey();

class MinhaClasse
{
    public void Saudacao()
    {
        Console.WriteLine("Bem-Vindo");
        ExibirDataAtual();
    }
    
    public void ExibirDataAtual()
    {
        Console.WriteLine(DateTime.Now.ToShortDateString());
    }
}