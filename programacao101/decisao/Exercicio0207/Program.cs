// See https://aka.ms/new-console-template for more information
Console.WriteLine("Cálculo de Bônus de Funcionário");
Console.Write("Digite o salário do funcionário: ");
double salario = Convert.ToDouble(Console.ReadLine());
Console.Write("A classificação de desempenho do funcionário: ");
var desempenho = Console.ReadLine();
double bonus = 0;

if (desempenho == "A")
{
    bonus = salario * 0.2;
}
else if (desempenho == "B")
{
    bonus = salario * 0.15;
}
else if (desempenho == "C")
{
    bonus = salario * 0.1;
}

Console.WriteLine($"Valor do bônus: R$ {bonus}");