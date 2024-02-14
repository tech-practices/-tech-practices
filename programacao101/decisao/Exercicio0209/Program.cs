// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write("Informe o salário atual do funcionário: ");
double salario = double.Parse(Console.ReadLine()!);
Console.Write("Informe a classificação de desempenho do funcionário ('A', 'B', 'C', 'D', 'E' ou outra): ");
var classificacao = Console.ReadLine();
Console.Write("Informe o número de anos trabalhados na empresa: ");
int anosServico = int.Parse(Console.ReadLine()!);

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

if (anosServico > 5) {
    bonus += salario * 0.05;
}

Console.WriteLine($"Valor do bônus: R$ {bonus}");
