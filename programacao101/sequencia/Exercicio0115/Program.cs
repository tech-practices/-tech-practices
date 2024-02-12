// See https://aka.ms/new-console-template for more information
Console.WriteLine("Caculadora de Tintas");
Console.Write("Digite a largura da parede do quarto: ");
double largura = double.Parse(Console.ReadLine()!);
Console.Write("Digite o comprimento (profundidade) da parede do quarto: ");
double comprimento = double.Parse(Console.ReadLine()!);
Console.Write("Digite a altura da parede do quarto: ");
double altura = double.Parse(Console.ReadLine()!);
Console.Write("Digite a área total das portas: ");
double areaPortas = double.Parse(Console.ReadLine()!);
Console.Write("Digite a área total das janelas: ");
double areaJanelas = double.Parse(Console.ReadLine()!);
double areaParede = (largura * altura * 2) + (comprimento * altura * 2);
double areaTotal = areaParede - (areaPortas + areaJanelas);
double litrosTinta = areaTotal / 10;
Console.WriteLine($"Tinta Necessári: {litrosTinta} litros");
