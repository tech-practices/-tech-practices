# Exercício 01.09 - Cálculo do IMC

## Enunciado

Escreva um programa que solicite a altura e o peso de uma pessoa e, em seguida, calcule e imprima o Índice de Massa Corporal (IMC) dessa pessoa.

## Entrada

A entrada consiste de duas linhas. A primeira linha contém a altura da pessoa (em metros). A segunda linha contém o peso da pessoa (em quilogramas).

## Saída

A saída deve conter uma linha com o IMC calculado da pessoa.

## Exemplos

```plaintext
>>>>>>>>
1.75
70
========
Seu IMC é: 22.86
<<<<<<<<
```

## Dica

O IMC é calculado dividindo o peso da pessoa (em quilogramas) pelo quadrado da sua altura (em metros). A fórmula do IMC é:

$$ IMC = \frac{peso}{altura^2} $$

Em C#, você pode usar `double.Parse(Console.ReadLine())` para ler números decimais e `Console.WriteLine()` para imprimir os resultados.

```csharp
double altura = double.Parse(Console.ReadLine());
double peso = double.Parse(Console.ReadLine());
double imc = peso / (altura * altura);
Console.WriteLine($"IMC: {imc:F2}");
```
