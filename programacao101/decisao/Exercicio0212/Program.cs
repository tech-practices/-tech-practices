// See https://aka.ms/new-console-template for more information
Console.WriteLine("Cálculo de Categoria por Idade");
Console.WriteLine("Digite a data de nascimento do atleta: ");
DateTime dataNascimento = DateTime.Parse(Console.ReadLine()!);
DateTime dataAtual = DateTime.Now;
var diferencaDatas = dataAtual.Subtract(dataNascimento);
var idade = diferencaDatas.Days / 365;

var categoria = string.Empty;

switch (idade)
{
    case int n when n <= 10:
        categoria = "Infantil";
        break;
    case int n when n >= 11 && n <= 17:
        categoria = "Juvenil";
        break;
    case int n when n >= 18 && n <= 59:
        categoria = "Adulto";
        break;
    case int n when n >= 60:
        categoria = "Sênior";
        break;
    default:
        categoria = "Categoria não encontrada";
        break;
}

Console.WriteLine($"O atleta tem {idade} anos e está na categoria {categoria}");
