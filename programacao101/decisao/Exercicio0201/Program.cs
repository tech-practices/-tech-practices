// See https://aka.ms/new-console-template for more information
Console.WriteLine("Determinando o Maior Número");
Console.Write("Digite o primeiro número: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o segundo número: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"O maior número é: {num1}");
}
else if (num2 > num1)
{
    Console.WriteLine($"O maior número é: {num2}");
}
else
{
    Console.WriteLine("Os números são iguais");
}
