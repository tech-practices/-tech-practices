// See https://aka.ms/new-console-template for more information
Console.WriteLine("Escolha de Assento em Voo");

Console.WriteLine("Digite o tipo de assento desejado: 'Janela', 'Corredor' ou 'Meio'");
string tipoAssento = Console.ReadLine()!.ToLower();

if (tipoAssento != "janela" && tipoAssento != "corredor" && tipoAssento != "meio")
{
    Console.WriteLine($"Tipo de assento não disponível: {tipoAssento}");
    return;
}

Console.WriteLine("Digite a preferência por espaço: 'Normal' ou 'Espaço Extra'");
string preferenciaEspaco = Console.ReadLine()!.ToLower();

if (preferenciaEspaco != "normal" && preferenciaEspaco != "espaço extra")
{
    Console.WriteLine($"Preferência por espaço não disponível: {preferenciaEspaco}");
    return;
}

double valor = 0;

switch (tipoAssento)
{
    case "janela":
        valor = (preferenciaEspaco == "normal") ? 300 : 350;
        break;
    case "corredor":
        valor = (preferenciaEspaco == "normal") ? 280 : 330;
        break;
    case "meio":
        valor = (preferenciaEspaco == "normal") ? 250 : 300;
        break;
    default:
        break;
}

Console.WriteLine($"Assento escolhido: {tipoAssento} - {preferenciaEspaco} - Custo R$ {valor:0.00}");