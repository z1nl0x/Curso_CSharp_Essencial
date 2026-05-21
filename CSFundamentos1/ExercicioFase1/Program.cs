
int idade = 35;
string nome = "Maria";
decimal altura = 3.45m;
DateTime data = new DateTime(1999, 09, 04);
Console.WriteLine(data);
Console.ReadKey();

const int ANO = 12;
double? nota = 7.80d;

// 7 - tipos por valor são valores atribuidas a variável e armazenam seus dados diretamente,
// e tipos por referencia são apenas endereços dos valores armazenados, ou seja ele armazena um ponteiro.

// Exercicio 8
/*  (int) - x = 10;
 *  (double) - numero = 7.99;
 *  (char) - letra = 'C';
 *  (float) - temperatura = 27.4f;
 *  (bool) - ativo = false;
 *  (string) - nome = "Manoel";
 *  (decimal) - salario = 950.99m;
 *  (DateTime) - hoje = DateTime.Now;
 */

// Exercicio 9
/* 
(V) int n = 1;
(R) string titulo = "A vida";
(V) float f = 12.45f;
(V) double d = 5.45;
(V) decimal valor = 10.99m;
(R) char sexo = ‘M’;
(R) object o = null;
*/

// Exercicio 10 - Nullable type é um tipo de dados que pode ser atribuido a uma variavel (null).

// Exercicio 11 - CamelCase é um padrão de nomenclatura utilizado onde iniciamos nomes de identificadores desta maneira: int valorDaNotaFiscal = 10;
// Sendo a primeira letra minuscula e o restante das outras palavras do identificador tendo a primeira letra maiuscula.

// Exercício 12 - PascalCase é um outro padrão de nomenclatura também, porém todos as iniciais das palavras do indentificador iniciam com a letra maiuscula, exemplo: int ValorDaNotaFiscal = 15;

int x = 77;
int y = 66;
Console.WriteLine($"{x + y}");

// Exercicio 14
// bool (true, false)
// char (qualquer caractere, apenas um)
// int (números inteiros)
// double, float, decimal (números reias com ponto flutuante)
// string (qualquer sequencia de caracteres)

// Exercicio 15
/*
(F) double 1valor = 12.45;
(F) string #nome = "Pedro";
(V) float _temperatura = 12.45f;
(V) double int = 5;
(F) decimal renda extra = 91.45m;
(V) bool status$conta = false;
(V) string titulo3 = “Tópico 1”;
(V) float salario_mensal = 1999.55f;
(V) int percentualValorDesconto = 5;
(V) const bool MENSALIDADE_EM_DIA = true;
*/