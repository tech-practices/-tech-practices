// See https://aka.ms/new-console-template for more information
Console.WriteLine("Conversor de Real para Dólar");
Console.Write("Digite o valor em reais: ");
double valorEmReais = double.Parse(Console.ReadLine()!);
Console.Write("Digite a cotação do Dólar: ");
double cotacaoDolar = double.Parse(Console.ReadLine()!);
double valorEmDolar = valorEmReais / cotacaoDolar;
Console.WriteLine($"O valor em dólar é: {valorEmDolar:F2}");
