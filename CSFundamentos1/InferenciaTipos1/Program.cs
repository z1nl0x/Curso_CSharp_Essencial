Console.WriteLine("##  Inferência Tipo (var) ##");

var idade = 25;
var nome = "Maria";
var salario = 2500.00m;

Console.WriteLine($"{nome} tem {idade} anos e ganha {salario.ToString("c")}");

// var limitações
// var salario2 = null;
// var titulo;
// var salario3, imposto, total;

// não posso mudar o tipo após inicializar
// var num = 10;
// num = num + 20;
// num = "Teste";

Console.ReadKey();