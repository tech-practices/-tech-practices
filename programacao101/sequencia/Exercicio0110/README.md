# Exercício 01.10 - Diferença de Quilometragem

## Enunciado

Escreva um programa que solicite dois valores de quilometragem em uma estrada e calcule a distância em quilômetros entre um ponto e outro. Importante: não utilize nenhum comando de decisão como `IF` ou `CASE`, e os valores podem ser fornecidos em qualquer ordem, seja o maior primeiro e o menor depois, ou vice-versa.

## Entrada

A entrada consiste de duas linhas, cada uma contendo um valor de quilometragem (números inteiros ou decimais).

## Saída

A saída deve conter uma linha com a distância calculada entre os dois pontos.

## Exemplos

```plaintext
>>>>>>>>
1200.5
1234.5
========
A distância entre os dois pontos é de 34 km.
<<<<<<<<

>>>>>>>>
1500
1475
========
A distância entre os dois pontos é de 25 km.
<<<<<<<<
```

## Dica

Para calcular a distância entre dois pontos sem usar comandos de decisão, você pode utilizar o valor absoluto da diferença entre os dois números. Em C#, o método `Math.Abs()` retorna o valor absoluto de um número.

```csharp
double quilometragem1 = double.Parse(Console.ReadLine());
double quilometragem2 = double.Parse(Console.ReadLine());
double distancia = Math.Abs(quilometragem1 - quilometragem2);
Console.WriteLine($"Distância: {distancia} km");
```
