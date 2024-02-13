// See https://aka.ms/new-console-template for more information
Console.WriteLine("Verificação de Aprovação de Aluno");
Console.Write("Digite a primeira nota do aluno: ");
double nota1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite a segunda nota do aluno: ");
double nota2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite a terceira nota do aluno: ");
double nota3 = Convert.ToDouble(Console.ReadLine());
double media = (nota1 + nota2 + nota3) / 3;
if (media >= 7)
{
    Console.WriteLine("Aluno aprovado.");
}
else
{
    Console.WriteLine("Aluno reprovado.");
}
