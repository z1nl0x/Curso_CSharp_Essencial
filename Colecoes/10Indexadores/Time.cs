namespace _10Indexadores;

public class Time
{
    // Definir os limites do Array
    string[] valor = new string[10];
    
    public string this[int i]
    {
        get
        {
            if (i >= 0 && i < valor.Length)
            {
                return valor[i];
            }

            return "Erro";
        }

        set
        {
            if (i >= 0 && i < valor.Length)
            {
                valor[i] = value;
            }
        }
    }
}