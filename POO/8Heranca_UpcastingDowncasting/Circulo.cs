namespace _8Heranca_UpcastingDowncasting;

public class Circulo : Forma
{
    public Circulo()
    {}

    public Circulo(int x, int y) : base(x, y)
    {
    }

    public override void Desenhar()
    {
        Console.WriteLine($"Desenhar - Forma na posição: ({xpos} , {ypos})");
    }
    
    public virtual void PintarCirculo()
    {
        Console.WriteLine("Pintar Circulo");
    }
}