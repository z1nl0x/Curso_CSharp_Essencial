Console.WriteLine("## Exercício Array ##\n");

string[] nomes = new string[5];
double[] notas = new double[5];

Console.WriteLine("## Alunos ##");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Informe o nome do aluno: ");
    string? nome = Console.ReadLine();
    nomes[i] = nome;
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Informe a nota do aluno: ");
    double nota = Convert.ToDouble(Console.ReadLine());
    notas[i] = nota;
}

foreach (var nome in nomes)
{
    Console.WriteLine($"\nNomes: \n{nome}");
}

var somaNotas = 0.0;
var totalNotas = notas.Count();
foreach (var nota in notas)
{
    somaNotas += nota;
    Console.WriteLine($"\nNota: {nota}");
}
Console.WriteLine($"\nMédia Aritmética : {somaNotas/totalNotas}\n");