Console.WriteLine("## Nullable Types ## \n");

Nullable<int> valor1 = null;
Nullable<double> valor2 = null;
Nullable<bool> valor3 = null;
Console.WriteLine(valor1);
Console.WriteLine(valor2);
Console.WriteLine(valor3);

// Simplificando a atribuição de uma variável para o tipo nullable
int? valor4 = null;
double? valor5 = null;
bool? valor6 = null;
Console.WriteLine(valor4);
Console.WriteLine(valor5);
Console.WriteLine(valor6);

// Operador de coalescência
int? a = null;
int b = a ?? 0;
Console.WriteLine(b);

Console.ReadKey();
