// See https://aka.ms/new-console-template for more information
Console.WriteLine("Cálculo de Bônus de Funcionário com Switch Case");
Console.Write("Digite o salário atual do funcionário: ");
double salario = double.Parse(Console.ReadLine()!);
Console.Write("Digite a classificação de desempenho do funcionário ('A', 'B', 'C', 'D', 'E' ou outra): ");
var classificacao = Console.ReadLine();
double bonus = 0;

switch (classificacao)
{
    case "A":
        bonus = salario * 0.2;
        break;
    case "B":
        bonus = salario * 0.15;
        break;
    case "C":
        bonus = salario * 0.10;
        break;
    case "D":
        bonus = salario * 0.05;
        break;
    case "E":
        bonus = salario * 0.02;
        break;
    default:
        bonus = 0;
        break;
}

Console.WriteLine($"Valor do bônus: R$ {bonus}");
