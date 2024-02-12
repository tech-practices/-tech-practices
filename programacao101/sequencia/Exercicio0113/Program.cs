// See https://aka.ms/new-console-template for more information
Console.WriteLine("Cálculo Geodésico de Distância");
Console.Write("Digite a latitude do ponto 1: ");
double lat1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite a longitude do ponto 1: ");
double lon1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite a latitude do ponto 2: ");
double lat2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite a longitude do ponto 2: ");
double lon2 = Convert.ToDouble(Console.ReadLine());

lat1 = lat1 * Math.PI / 180;
lon1 = lon1 * Math.PI / 180;
lat2 = lat2 * Math.PI / 180;
lon2 = lon2 * Math.PI / 180;

double deltaLat = lat2 - lat1;
double deltaLon = lon2 - lon1;
double r = 6371;

double a = Math.Pow(Math.Sin(deltaLat / 2), 2) + Math.Cos(lat1) * Math.Cos(lat2) * Math.Pow(Math.Sin(deltaLon / 2), 2);
double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
double distancia = r * c;

Console.WriteLine($"A distância entre os pontos é de {distancia} km");
