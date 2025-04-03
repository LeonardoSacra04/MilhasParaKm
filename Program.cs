double milhas;
double km;


Console.Clear();

Console.WriteLine("Digite a quantidade de milhas a ser convertida em Km: ");
milhas = Convert.ToDouble(Console.ReadLine()!);

km = milhas * 1.609;

Console.Clear();

Console.WriteLine($"Medida em milhas: {milhas}");
Console.WriteLine($"Medida em quilômetros: {km}");