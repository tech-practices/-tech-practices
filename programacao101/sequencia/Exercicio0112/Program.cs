// See https://aka.ms/new-console-template for more information
Console.WriteLine("Calculadora de Velocidade Média");
Console.Write("Digite tempo gasto na viagem: ");
double tempo = double.Parse(Console.ReadLine()!);
Console.Write("Digite a distância percorrida: ");
double distancia = double.Parse(Console.ReadLine()!);
double velocidade = distancia / tempo;
Console.WriteLine($"Velocidade média: {velocidade} km/h");
