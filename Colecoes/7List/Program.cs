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
// var fruta1 = frutas.Find("Teste");

Console.ReadKey();