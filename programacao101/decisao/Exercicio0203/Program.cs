// See https://aka.ms/new-console-template for more information
Console.WriteLine("Comparação de Preços de Produtos");
Console.Write("Digite o nome do produto: ");
string nomeProduto = Console.ReadLine()!;
Console.Write("Digite o preço do produto, no primeiro estabelecimento: ");
double precoProduto1 = double.Parse(Console.ReadLine()!);
Console.Write("Digite o preço do produto, no segundo estabelecimento: ");
double precoProduto2 = double.Parse(Console.ReadLine()!);

if (precoProduto1 < precoProduto2)
{
    Console.WriteLine($"O produto {nomeProduto} é mais barato no primeiro estabelecimento.");
}
else if (precoProduto1 > precoProduto2)
{
    Console.WriteLine($"O produto {nomeProduto} é mais barato no segundo estabelecimento.");
}
else
{
    Console.WriteLine($"Os preços do produto {nomeProduto} são iguais nos dois estabelecimentos.");
}
