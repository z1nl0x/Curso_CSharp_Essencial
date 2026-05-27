Console.WriteLine("## Arrays ##\n");

int[] numeros;

numeros = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
string[] nomes = new string[5] {"Ana", "Maria", "Marta", "Paulo", "Milena"};
// maneira simplificada
string[] nomes2 = {"Ana", "Maria", "Marta", "Paulo", "Milena"};

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Elemento de índice {i} : {numeros[i]}");
}

foreach (var num in  numeros)
{
    Console.WriteLine(num);
}

Console.ReadKey();
