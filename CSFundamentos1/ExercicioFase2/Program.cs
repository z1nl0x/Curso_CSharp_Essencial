Console.WriteLine("## Exercícios Fase 2 ##\n");

// Exercício 1
// var nome = "Paulo";
// var idade = 17;
// var nota = 7.5;
// Console.WriteLine("Aluno " + nome + " tem " + idade + " anos e nota " + nota);
// Console.WriteLine($"Alune {nome} tem {idade} anos e nota {nota}");

// Exercicio 2
// Console.WriteLine($"Aluno {nome}\ntem {idade} anos\ne nota {nota}");

// 3- Para qual tipo de dados você pode converter um float implicitamente ?
//     ( ) int
//     (X) double
//     ( ) long
//     (X) decimal

// 4- Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ?
//     ( ) int para long
//     ( ) double para long
//     (X) double para float
//     (X) decimal para float
//     (X) long para int
//     (X) double para decimal

// Exercicio 5
// string letra1, letra2, letra3;
// Console.Write("Digite a letra1: ");
// letra1 = Console.ReadLine();
// Console.Write("\nDigite a letra2: ");
// letra2 = Console.ReadLine();
// Console.Write("\nDigite a letra3: ");
// letra3 = Console.ReadLine();
//
// Console.WriteLine(letra3 + letra2 + letra1);
// Console.WriteLine($"{letra3}{letra2}{letra1}");

// 6- Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
// (F) long resultado = 1.32;
// (V) var nome = “Maria”;
// (V) string resultado = 100.ToString();
// (V) A sequência de escape \n inclui uma nova linha
// (F) float f = 5.45;
// (V) decimal valor = (decimal) 10.99f;
// (F) var status = null;
// (V) object o = 12.45m;
// (V) string titulo = true.ToString();
// (F) A sequencia \t inclui uma tabulação vertical


// 7- Escreva um programa para receber dois valores via teclado do tipo double e a seguir
// realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo
// exibindo o resultado:

// double v1;
// double v2;
// Console.WriteLine("Digite o Valor1: ");
// v1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Digite o Valor2: ");
// v2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine($"Soma: {v1+v2}\n");
// Console.WriteLine($"Subtração: {v1-v2}\n");
// Console.WriteLine($"Multiplicação: {v1*v2}\n");
// Console.WriteLine($"Exponênciação: {Math.Pow(v1, v2)}\n");
// Console.WriteLine($"Divisão: {v1/v2}\n");
// Console.WriteLine($"Módulo: {v1%v2}\n");

// Exercicio 8

// Exercicio 9

// string nome;
// Console.Write("Digite o nome: ");
// nome = Console.ReadLine();
//
// int senha;
// Console.Write("Digite o seu senha: ");
// senha = Convert.ToInt32(Console.ReadLine());
//
// Console.WriteLine(nome == "admin" || nome == "maria" && senha == 123 ? "Login feito com sucesso" : "Login inválido");


// 10- Indique verdadeiro(V) ou falso (F) para as seguintes declarações de variáveis considerando
// a nomenclatura usada:
// (V) string? nome; é um exemplo de nullable reference type;
// (F) para x igual a 0 , Console.WriteLine(x++); imprime o valor 1
// (F) A ordem de precedência dos operadores lógicos é : ! , || e && (NOT, OR e AND)
// (V) para y igual a 0 , Console.WriteLine(++y); imprime o valor 1
// (F) (10 % 2 == 0) ? “Par” : “Impar”; Vai retornar “Impar”
// (F) Para x=25 e y=5 , a expressão ( y >= x ) && ( y <= x ); retorna true;
// (V) Os nullable reference types emitem um alerta em tempo de compilação para uso do null
// (F) Para x = 10 , o código Console.WriteLine(x+=x); imprime o valor 10;
// (F) Para x= 5 , a expressão !(9 >= x) && x <= 7 || x == 5); retorna false;
// (V) O operador ?. permite verificar se um objeto é null e evitar o NullReferenceException
// (V) Qualquer tipo de dado pode ser declarado como anulável com a ajuda do operador "?"