Console.WriteLine("## Herança ##\n");

Funcionario funci = new();
funci.Nome = "Paulo";
funci.Email = "paulo@email.com";
funci.Empresa = "Anthropic";
funci.Salario = 17000;

Console.WriteLine("Funcionario");
Console.WriteLine(funci.Empresa);
Console.WriteLine(funci.Salario);
funci.Identificar();

Aluno aluno = new Aluno();
aluno.Nome = "José";
aluno.Email = "jose@email.com";
aluno.Curso = "Ciência da Computação";
aluno.Nota = 10;

Console.WriteLine("\nAluno");
Console.WriteLine(aluno.Curso);
Console.WriteLine(aluno.Nota);
aluno.Identificar();

Console.ReadKey();

public class Pessoa
{
    public string? Nome { get; set; }
    public string? Email { get; set; }

    public void Identificar()
    {
        Console.WriteLine($"Nome: {Nome}, Email: {Email}");
    }
}

public class Funcionario : Pessoa
{
    public string? Empresa { get; set; }
    public decimal Salario { get; set; }
}

public class Aluno : Pessoa
{
    public string? Curso { get; set; }
    public int Nota { get; set; }
}