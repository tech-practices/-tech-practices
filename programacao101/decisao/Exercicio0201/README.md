# Exercício 01.20 - Determinando o Maior Número

## Enunciado

Desenvolva um programa em C# que receba dois números inteiros e determine qual deles é o maior. O programa deve imprimir o maior número recebido, utilizando lógica de decisão para comparar os valores.

## Entrada

A entrada consiste de duas linhas:

1. O primeiro número inteiro.
2. O segundo número inteiro.

## Saída

A saída deve conter uma linha com o maior número entre os dois fornecidos.

## Exemplos

```plaintext
>>>>>>>>
15
8
========
O maior número é: 15
<<<<<<<<

>>>>>>>>
7
42
========
O maior número é: 42
<<<<<<<<
```

## Dica

Utilize uma estrutura de decisão `if` para comparar os dois números. Se o primeiro número for maior que o segundo, imprima o primeiro. Caso contrário, imprima o segundo.

```csharp
if (numero1 > numero2) {
    // ...
}
```
