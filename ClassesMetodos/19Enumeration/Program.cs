Console.WriteLine("## Enum ##\n");

Console.WriteLine($"{Categorias.Moda} - {(int)Categorias.Livros}");
Console.WriteLine(DiasDaSemana.Domingo);

int dia1 = (int)DiasDaSemana.Domingo;
int dia2 = (int)DiasDaSemana.Terça;

Console.WriteLine($"\n{DiasDaSemana.Domingo} vale : {dia1}");
Console.WriteLine($"\n{DiasDaSemana.Terça} vale : {dia2}");

Console.ReadKey();

enum Categorias
{
    Moda,
    Automativo,
    Artes,
    Bebidas,
    Livros,
    Brinquedos
}

enum DiasDaSemana
{
    Segunda,
    Terça,
    Quarta = 5,
    Quinta,
    Sexta,
    Sábado,
    Domingo
}