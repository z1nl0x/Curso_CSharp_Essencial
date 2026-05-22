Console.WriteLine("## Instrução if-else ##\n");

Console.WriteLine("Informe a nota do aluno \t");
var nota = Convert.ToInt32(Console.ReadLine());

if (nota > 5)
{
    Console.WriteLine("Aluno Aprovado");
}
else
{
    Console.WriteLine("Aluno Reprovado");
}

Console.WriteLine("Fim do processamento!");
Console.ReadKey();