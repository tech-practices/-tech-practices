// See https://aka.ms/new-console-template for more information
Console.WriteLine("Custo de Viagem");
Console.Write("Digite o nome da cidade a visitar: ");
var cidade = Console.ReadLine();
Console.Write("Digite a distância em km, à partir da sua casa até a cidade: ");
var distancia = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o consumo do seu veículo em km/l: ");
var consumo = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o preço do combustível: ");
var preco = Convert.ToDouble(Console.ReadLine());
var litros = distancia / consumo;
var custo = litros * preco;
Console.WriteLine($"Cidade: {cidade}");
Console.WriteLine($"Custo da Viagem: R$ {custo:0.00}");
