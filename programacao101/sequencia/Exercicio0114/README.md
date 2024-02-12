# Exercício 01.14 - Conversão de Moedas

## Enunciado

Escreva um programa que solicite um valor em reais (R$) e a cotação atual do dólar (US$). Em seguida, calcule e imprima o valor convertido em dólares.

## Entrada

A entrada consiste de duas linhas. A primeira linha contém o valor em reais que deseja converter. A segunda linha contém a cotação atual do dólar.

## Saída

A saída deve conter uma linha com o valor convertido em dólares.

## Exemplos

```plaintext
>>>>>>>>
100
5.25
========
Dólares: 19.05
<<<<<<<<

>>>>>>>>
250
5.10
========
Dólares: 49.02
<<<<<<<<
```

## Dica

Para converter o valor de reais para dólares, você deve dividir o valor em reais pela cotação do dólar.

Em C#, você pode usar `double.Parse(Console.ReadLine())` para ler números decimais e `Console.WriteLine()` para imprimir os resultados.

```csharp
double valorReais = double.Parse(Console.ReadLine());
double cotacaoDolar = double.Parse(Console.ReadLine());
double valorDolares = valorReais / cotacaoDolar;
Console.WriteLine($"Dólares: {valorDolares:F2}");
```
