// See https://aka.ms/new-console-template for more information
Console.WriteLine("Calculadora de Remuneração de PJ MEI");
Console.Write("Digite o valor da hora trabalhada (R$): ");
double valorHora = double.Parse(Console.ReadLine()!);
Console.Write("Digite a quantidade de horas trabalhadas: ");
double horasTrabalhadas = double.Parse(Console.ReadLine()!);
double salarioBruto = valorHora * horasTrabalhadas;
double imposto = salarioBruto * 0.06;
double salarioLiquido = salarioBruto - imposto;
Console.WriteLine($"Valor Bruto: R$ {salarioBruto}");
Console.WriteLine($"Imposto: R$ {imposto}");
Console.WriteLine($"Valor Líquido: R$ {salarioLiquido}");
