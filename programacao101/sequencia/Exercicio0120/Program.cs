// See https://aka.ms/new-console-template for more information
Console.WriteLine("Álcool ou Gasolina?");
Console.Write("Digite o preço do álcool:");
double precoAlcool = double.Parse(Console.ReadLine()!);
Console.Write("Digite o preço da gasolina:");
double precoGasolina = double.Parse(Console.ReadLine()!);
double resultado = precoAlcool / precoGasolina;
if (resultado <= 0.7)
{
    Console.WriteLine("Abasteça com álcool");
}
else
{
    Console.WriteLine("Abasteça com gasolina");
}
