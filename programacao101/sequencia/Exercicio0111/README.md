# Exercício 01.11 - Conversão de Celsius para Fahrenheit

## Enunciado

Escreva um programa que solicite uma temperatura em graus Celsius e calcule o correspondente em Fahrenheit.

## Entrada

A entrada consiste de uma linha contendo um número que representa a temperatura em graus Celsius (pode ser um número inteiro ou decimal).

## Saída

A saída deve conter uma linha com a temperatura convertida para Fahrenheit.

## Exemplos

```plaintext
>>>>>>>>
25
========
A temperatura em Fahrenheit é 77.00
<<<<<<<<

>>>>>>>>
0
========
A temperatura em Fahrenheit é 32.00
<<<<<<<<
```

## Dica

Para converter uma temperatura de Celsius para Fahrenheit, você pode usar a fórmula:

$$ F = C \times \frac{9}{5} + 32 $$

onde \( F \) é a temperatura em Fahrenheit e \( C \) é a temperatura em Celsius.

Em C#, você pode usar `double.Parse(Console.ReadLine())` para ler números decimais e `Console.WriteLine()` para imprimir os resultados.

```csharp
double celsius = double.Parse(Console.ReadLine());
double fahrenheit = (celsius * 9/5) + 32;
Console.WriteLine($"Fahrenheit: {fahrenheit:F2}");
```
