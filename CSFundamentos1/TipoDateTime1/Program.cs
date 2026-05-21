Console.WriteLine("## Struct DateTime  ##\n");

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

// Criar um data específica utiliza o formato: AAAA,MM,DD

DateTime dataHoje = new DateTime(2026, 05, 21);
Console.WriteLine(dataHoje);

DateTime dataHoraHoje = new DateTime(2026, 05, 21, 09, 25, 30);
Console.WriteLine(dataHoraHoje);

// Extraindo informações da data atual
Console.WriteLine(dataAtual.Year);
Console.WriteLine(dataAtual.Month);
Console.WriteLine(dataAtual.Day);
Console.WriteLine(dataAtual.Hour);
Console.WriteLine(dataAtual.Minute);
Console.WriteLine(dataAtual.Second);
Console.WriteLine(dataAtual.Millisecond);

// Adicionando valores as datas
Console.WriteLine(dataAtual.AddDays(30));
Console.WriteLine(dataAtual.AddMonths(1));
Console.WriteLine(dataAtual.AddYears(5));
Console.WriteLine(dataAtual.AddHours(3));

// Obter o dia da semana e do ano
Console.WriteLine(dataAtual.DayOfWeek);
Console.WriteLine(dataAtual.DayOfYear);

// Expressar data no formato curto e longo
Console.WriteLine(dataAtual.ToLongDateString());
Console.WriteLine(dataAtual.ToShortDateString());

Console.WriteLine(dataAtual.ToLongTimeString());
Console.WriteLine(dataAtual.ToShortTimeString());

Console.ReadKey();