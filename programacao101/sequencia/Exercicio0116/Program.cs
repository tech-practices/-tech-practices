// See https://aka.ms/new-console-template for more information
Console.WriteLine("Iversor de formado UDC (Unidade, dezena e centena) para formato CDU (Centena, dezena e unidade)");
Console.WriteLine("Digite o númro no formato UDC para converter para CDU");
int numero = int.Parse(Console.ReadLine()!);
int unidade = numero % 10;
int dezena = (numero / 10) % 10;
int centena = numero / 100;
int numeroConvertido = unidade * 100 + dezena * 10 + centena;
Console.WriteLine($"O número {numero} convertido para CDU é {numeroConvertido}");

