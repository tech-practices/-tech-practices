// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hidratação de Funcionários");
Console.Write("Digite o nome do funcionário: ");
string nome = Console.ReadLine()!;
Console.Write("Digite o peso do funcionário (Kg): ");
int peso = int.Parse(Console.ReadLine()!);
Console.Write("Digite a quantidade de água que o funcionário bebeu hoje (em ml): ");
int ml = int.Parse(Console.ReadLine()!);
int mlPorKg = peso * 35/1000;
if (ml < mlPorKg)
{
    Console.WriteLine($"O funcionário {nome} bebeu menos água do que o recomendado. Ele deveria ter bebido {mlPorKg} ml de água e bebeu apenas {ml} ml.");
}
else
{
    Console.WriteLine($"O funcionário {nome} bebeu a quantidade de água recomendada. Ele deveria ter bebido {mlPorKg} ml de água e bebeu {ml} ml.");
}