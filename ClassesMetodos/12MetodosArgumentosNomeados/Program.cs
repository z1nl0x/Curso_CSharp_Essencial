Console.WriteLine("## Argumentos nomeados ##\n");

Email email = new();

email.Enviar("teste@email.com", "Reunião de Orçamento", "Urgente");

// Argumentos nomeados
email.Enviar(titulo: "Urgente", destino: "teste2@email.com", assunto: "Reunião de Orçamento2");

Console.ReadKey();

public class Email
{
    public void Enviar(string destino, string titulo, string assunto)
    {
        Console.WriteLine($"\npara {destino} - {titulo} \n Assunto: {assunto}");
    }
}