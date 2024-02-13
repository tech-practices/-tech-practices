// See https://aka.ms/new-console-template for more information
Console.WriteLine("Classificação de Triângulos");
Console.Write("Digite o valor do lado 1: ");
double lado1 = double.Parse(Console.ReadLine());
Console.Write("Digite o valor do lado 2: ");
double lado2 = double.Parse(Console.ReadLine());
Console.Write("Digite o valor do lado 3: ");
double lado3 = double.Parse(Console.ReadLine());

if (lado1 == lado2 && lado2 == lado3)
{
    Console.WriteLine("Triângulo Equilátero");
}
else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
{
    Console.WriteLine("Triângulo Isósceles");
}
else
{
    Console.WriteLine("Triângulo Escaleno");
}
