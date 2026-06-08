using _10Indexadores;

Console.WriteLine("## Indexadores ##");

Time time = new Time();

time[1] = "Santos";
time[3] = "Corinthians";
time[5] = "Flamengo";
time[7] = "Vasco";

string valor1 = time[1];
string valor2 = time[3];

Console.WriteLine(valor1);
Console.WriteLine(valor2);

Console.ReadKey();