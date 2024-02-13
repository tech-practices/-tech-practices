// See https://aka.ms/new-console-template for more information
Console.WriteLine("Cálculo de Tarifa de Energia");
Console.Write("Digite o consumo de energia em kWh: ");
double consumo = double.Parse(Console.ReadLine()!);
double tarifa = 0.85;
double valor = 0;

if (consumo <= 100)
{
    valor = consumo * (tarifa * 0.85);
}
else if (consumo > 100 && consumo <= 200)
{
    valor = consumo * (tarifa * 0.90);
}
else if (consumo > 200)
{
    valor = consumo * tarifa;
}

Console.WriteLine($"O valor da tarifa: R$ {valor}");