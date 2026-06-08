Console.WriteLine("## Coleção List ##\n");

// Declarando e inicializando uma coleção List<T>

// List<string> lista;
// lista = new List<string>();
//
// List<int> lista1 = new List<int>();
// var lista2 = new List<float>();
// List<double> lista3 = new();
//
// List<string> nomes = new();
// nomes.Add("Paulo");
// nomes.Add("Maria");
//
// var lista4 = new List<string>()
// {
//     "Paulo", "Maria", "Bia", "Manoel"
// };

var lista = new List<string>() { "Maria", "Ana", "Pedro", "Carlos", "Zé" };
string[] array1 = { "Diná", "Carlos", "Peter" };

lista.Add("Marta");
lista.Insert(2, "Bia");
lista.AddRange(array1);
lista.InsertRange(1, array1);

var res1 = lista.Contains("Ana");
lista.Sort();
lista.Clear();

List<string> frutas = new() { "Uva", "Banana", "Pera", "Maçã", "Abacate", "Laranja", "Morango" };
var fruta1 = frutas.Find(Procura);
Console.WriteLine(fruta1);

var fruta2 = frutas.Find(i => i.Contains('n'));
Console.WriteLine($"\nExpressão Lambda => {fruta2}");

var fruta3 = frutas.FindLast(i => i.Contains('n'));
Console.WriteLine($"\nFindLast: {fruta3}");

var frutas4 = frutas.FindIndex(i => i.Contains('n'));
Console.WriteLine($"\nFindIndex : indice={frutas4} item={frutas[frutas4]}");

var frutas5 = frutas.FindLastIndex(i => i.Contains('n'));
Console.WriteLine($"\nFindLastIndex : indice={frutas5} item={frutas[frutas5]}");

var frutas6 = frutas.FindAll(i => i.Contains('n'));
Console.WriteLine("\nFindAll :");
foreach (var item in frutas6)
{
    Console.WriteLine($"{item} ");
}

Console.ReadKey();

static bool Procura(string item)
{
    return item.Contains('n');
}