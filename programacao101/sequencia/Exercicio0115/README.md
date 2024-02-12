# Exercício 01.15 - Cálculo de Tinta para Pintura de Quarto

## Enunciado

Escreva um programa que solicite as dimensões de um quarto (largura, comprimento e altura) e a área das portas e janelas. Em seguida, calcule a quantidade de tinta necessária para pintar as paredes do quarto, sabendo que cada litro de tinta pinta 10 metros quadrados.

## Entrada

A entrada consiste de cinco linhas. As três primeiras linhas contêm a largura, o comprimento e a altura do quarto, respectivamente. A quarta linha contém a área total das portas e a quinta linha contém a área total das janelas.

## Saída

A saída deve conter uma linha com a quantidade de tinta necessária para pintar o quarto (em litros).

## Exemplos

```plaintext
>>>>>>>>
4
5
3
2
1.5
========
Tinta Necessária: 5.7 litros
<<<<<<<<

>>>>>>>>
6
7
2.5
3
2
========
Tinta Necessária: 8.5 litros
<<<<<<<<
```

## Dica

Para calcular a quantidade de tinta necessária, primeiro calcule a área das paredes subtraindo a área das portas e janelas. Depois, divida a área total pelo rendimento da tinta (10 m² por litro).

Em C#, você pode usar `double.Parse(Console.ReadLine())` para ler números decimais e `Console.WriteLine()` para imprimir os resultados.

```csharp
double largura = double.Parse(Console.ReadLine());
double comprimento = double.Parse(Console.ReadLine());
double altura = double.Parse(Console.ReadLine());
double areaPortas = double.Parse(Console.ReadLine());
double areaJanelas = double.Parse(Console.ReadLine());

double areaParedes = 2 * (largura + comprimento) * altura - (areaPortas + areaJanelas);
double tintaNecessaria = areaParedes / 10;
Console.WriteLine($"Tinta Necessária: {tintaNecessaria:F1} litros");
```
