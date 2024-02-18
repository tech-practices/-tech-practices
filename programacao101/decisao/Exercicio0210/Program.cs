// See https://aka.ms/new-console-template for more information
Console.OutputEncoding = System.Text.Encoding.Latin1;
Console.InputEncoding = System.Text.Encoding.Latin1;

Console.WriteLine("Decisão de Rotas de Viagem de Avião");

Console.Write("Digite o destino da viagem de avião: ");
var destino = Console.ReadLine()!.ToLower();

if (destino != "paris" && destino != "nova york" && destino != "tóquio")
{
    Console.WriteLine($"Destino não disponível: {destino}");
    return;
}

Console.Write("Digite a preferência do viajante: 'Rápida', 'Barata' ou 'Menos Escalas': ");
var preferencia = Console.ReadLine()!.ToLower();

if (preferencia != "rápida" && preferencia != "barata" && preferencia != "menos escalas")
{
    Console.WriteLine($"Preferência não disponível: {preferencia}");
    return;
}

var duracao = 0;
var preco = 0;
var escalas = 0;

if (destino == "paris")
{
    if (preferencia == "rápida")
    {
        duracao = 7;
        preco = 900;
        escalas = 1;
    }
    else if (preferencia == "barata")
    {
        duracao = 12;
        preco = 750;
        escalas = 2;
    }
    else if (preferencia == "menos escalas")
    {
        duracao = 10;
        preco = 850;
        escalas = 1;
    }
}
else if (destino == "nova york")
{
    if (preferencia == "rápida")
    {
        duracao = 15;
        preco = 650;
        escalas = 3;
    }
    else if (preferencia == "barata")
    {
        duracao = 20;
        preco = 500;
        escalas = 4;
    }
    else if (preferencia == "menos escalas")
    {
        duracao = 18;
        preco = 550;
        escalas = 3;
    }
}
else if (destino == "tóquio")
{
    if (preferencia == "rápida")
    {
        duracao = 20;
        preco = 1200;
        escalas = 1;
    }
    else if (preferencia == "barata")
    {
        duracao = 25;
        preco = 1000;
        escalas = 1;
    }
    else if (preferencia == "menos escalas")
    {
        duracao = 22;
        preco = 1100;
        escalas = 1;
    }
}

Console.WriteLine($"Destino: {destino}");
Console.WriteLine($"Preferência: {preferencia}");
Console.WriteLine($"Rota escolhida: Duração {duracao}h - Preço R${preco} - Escalas {escalas}");
