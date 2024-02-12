// See https://aka.ms/new-console-template for more information
Console.WriteLine("Calculo de IMC");
Console.WriteLine("Digite sua altura: ");
double altura = double.Parse(Console.ReadLine()!);
Console.WriteLine("Digite seu peso: ");
double peso = double.Parse(Console.ReadLine()!);
double imc = peso / (altura * altura);
Console.WriteLine($"Seu IMC é: {imc}");
