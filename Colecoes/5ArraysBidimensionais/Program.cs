Console.WriteLine("## Arrays Bidimensionais ##\n");

int[,] a;

a = new int[2, 2];
a[0, 0] = 10;
a[0, 1] = 11;
a[1, 0] = 12;
a[1, 1] = 13;

Console.WriteLine(a[0, 0]);
Console.WriteLine(a[0, 1]);
Console.WriteLine(a[1, 0]);
Console.WriteLine(a[1, 1]);

int [,] b = new int[2, 2] { { 20, 30 }, { 40, 50 } };

Console.WriteLine(b[0, 0]);
Console.WriteLine(b[0, 1]);
Console.WriteLine(b[1, 0]);
Console.WriteLine(b[1, 1]);


int[,] n = { { 11, 22, 33 }, { 44, 55, 66 }, { 77, 88, 99 } };

for (int i = 0; i < n.GetLength(0); i++)
{
    for (int j = 0; j < n.GetLength(1); j++)
    {
        Console.WriteLine(n[i, j]);
    }
}

// Exemplo utilizando foreach para iterar no array bidimensional
foreach (int x in n)
{
    Console.WriteLine(x);
}

Console.ReadKey();