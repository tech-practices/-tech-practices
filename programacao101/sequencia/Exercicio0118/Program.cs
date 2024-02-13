// See https://aka.ms/new-console-template for more information
Console.WriteLine("Cálculo de Consumo Energético");
Console.Write("Digite a potência do aparelho em watts: ");
double potencia = double.Parse(Console.ReadLine()!);
Console.Write("Digite a quantidade de horas que o aparelho ficará ligado: ");
double horas = double.Parse(Console.ReadLine()!);
Console.Write("Digite a quantidade de dias que o aparelho ficará ligado: ");
double dias = double.Parse(Console.ReadLine()!);
double valorKwh = 0.75;
double consumo = (potencia * horas * dias) / 1000;
double custo = consumo * valorKwh;
Console.WriteLine($"Consumo Total: {consumo} kWh");
Console.WriteLine($"Custo: R$ {custo}");
