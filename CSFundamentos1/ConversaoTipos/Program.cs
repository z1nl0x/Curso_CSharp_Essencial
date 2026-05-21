Console.WriteLine("## Conversão de Tipos ##\n");

// Conversão implicita
int varInt = 100;
double varDouble = varInt;

// Conversão explicita
double varDouble2 = 12.456;
int varInt2 = (int)varDouble2;

int num1 = 10;
int num2 = 4;

float resultado = (float)num1 / num2;

// Conversão de valores numericos para string
int valorInt3 = 123;
double valorDouble3 = 12.45;
decimal valorDecimal3 = 12.45678m;

string s1 = valorInt3.ToString();
string s2 = valorDouble3.ToString();
string s3 = valorDecimal3.ToString();
Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);
Console.WriteLine();

Console.WriteLine(varDouble);
Console.WriteLine(varInt2);
Console.WriteLine(resultado);
Console.WriteLine();

// Outras conversões utilizando a classe Convert
int valorInt4 = 10;
double valorDouble4 = 5.35;
bool valorBool = true;

Console.WriteLine(Convert.ToString(valorInt4));
Console.WriteLine(Convert.ToDouble(valorDouble4));
Console.WriteLine(Convert.ToString(valorBool));
Console.WriteLine(Convert.ToInt32(valorDouble4));

Console.ReadLine();