// See https://aka.ms/new-console-template for more information
var nome1 = Console.ReadLine();
var idade1 = int.Parse(Console.ReadLine());
var nome2 = Console.ReadLine();
var idade2 = int.Parse(Console.ReadLine());
var nome3 = Console.ReadLine();
var idade3 = int.Parse(Console.ReadLine());
var nome4 = Console.ReadLine();
var idade4 = int.Parse(Console.ReadLine());
var nome5 = Console.ReadLine();
var idade5 = int.Parse(Console.ReadLine());
var nome6 = Console.ReadLine();
var idade6 = int.Parse(Console.ReadLine());

var soma = idade1 + idade2 + idade3 + idade4 + idade5 + idade6;
var media = soma / 6.0;

Console.WriteLine($"{nome1}: {idade1}");
Console.WriteLine($"{nome2}: {idade2}");
Console.WriteLine($"{nome3}: {idade3}");
Console.WriteLine($"{nome4}: {idade4}");
Console.WriteLine($"{nome5}: {idade5}");
Console.WriteLine($"{nome6}: {idade6}");
Console.WriteLine($"Soma das Idades: {soma}");
Console.WriteLine($"Média das Idades: {media}");
