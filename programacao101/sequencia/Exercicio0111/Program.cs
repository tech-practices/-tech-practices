// See https://aka.ms/new-console-template for more information
Console.WriteLine("Conversor de unidades de temperatura");
Console.Write("Digite a temperatura em Celsius: ");
double celsius = double.Parse(Console.ReadLine()!);
double fahrenheit = celsius * 9 / 5 + 32;
Console.WriteLine($"A temperatura em Fahrenheit é {fahrenheit}"); 

