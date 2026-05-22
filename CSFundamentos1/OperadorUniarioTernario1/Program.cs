Console.WriteLine("## Operador Uniário e Ternário ##\n");

// int positivo = 1;
// int resultado;
//
// resultado = +positivo;
// Console.WriteLine(resultado);

// Console.WriteLine("informe o número: \n");
// var n = Convert.ToInt32(Console.ReadLine());
//
// Console.WriteLine($"O negativo de {n} é {-n}");


Console.WriteLine("informe a temperatura: \n");
var temp = Convert.ToDouble(Console.ReadLine());

var resultado = temp > 27 ? "Quente" : "Normal";

Console.WriteLine($"O tempo esta {resultado}");

Console.ReadKey();