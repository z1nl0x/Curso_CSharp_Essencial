using _8Heranca_UpcastingDowncasting;

Console.WriteLine("## Herança Updacasting Downcasting ##\n");

// Forma circulo = new Circulo(10, 20); // Upcasting
// circulo.Desenhar();

Circulo circulo = new Circulo(10, 20);
Forma forma = circulo; // Upcasting
forma.Desenhar();

// Realizando o Downcasting
Circulo c = (Circulo)forma; // Downcasting
c.Desenhar();

Console.ReadKey();