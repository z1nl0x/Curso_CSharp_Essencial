namespace _20ModificadoresAcesso;

internal struct MinhaStruct
{
    int MeuCampo;
    private string? MinhaPropriedade { get; set; }

    void MeuMetodo()
    {
        Console.WriteLine("Meu Metodo");
    }
}