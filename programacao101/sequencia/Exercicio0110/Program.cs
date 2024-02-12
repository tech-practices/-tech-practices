// See https://aka.ms/new-console-template for more information
Console.WriteLine("Calculadora de Distância");
Console.Write("Entre com a primeira quilometragem: ");
double km1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Entre com a segunda quilometragem: ");
double km2 = Convert.ToDouble(Console.ReadLine());
double distancia = Math.Abs(km2 - km1);
Console.WriteLine($"A distância entre os dois pontos é de {distancia} km.");

