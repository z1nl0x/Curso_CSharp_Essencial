Console.WriteLine("## Break e Continue ##\n");

// Utilização do Break no For loop
// for (;;)
// {
//     Console.WriteLine("Tecle algo (X sai)");
//     var opcao = Console.ReadLine();
//
//     if (opcao == "X" || opcao == "x")
//     {
//         Console.WriteLine("Tchau...");
//         break;
//     }
// }

// Utilização do Continue no For loop
for (int i = 1; i <= 10; i++)
{
    if (i == 4)
    {
        continue;
    }
    
    Console.WriteLine(i);
}

Console.WriteLine("\nFim do Processamento!");
Console.ReadKey();