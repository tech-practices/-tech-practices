# Exercício 02.02 - Determinando o Maior entre Três Números

## Enunciado

Desenvolva um programa que receba três números inteiros e determine qual deles é o maior. O programa deve imprimir o maior número recebido, utilizando lógica de decisão para comparar os valores.

## Entrada

A entrada consiste de três linhas:

1. O primeiro número inteiro.
2. O segundo número inteiro.
3. O terceiro número inteiro.

## Saída

A saída deve conter uma linha com o maior número entre os três fornecidos.

## Exemplos

```plaintext
>>>>>>>>
12
25
7
========
O maior número é: 25
<<<<<<<<

>>>>>>>>
45
45
46
========
O maior número é: 46
<<<<<<<<
```

## Dica

Utilize uma estrutura de decisão `if` para comparar os três números. Determine o maior número comparando-os dois a dois.

Existem várias formas de se posicionar os `if`'s para comparar os números. Uma forma é a seguinte:

```csharp

if (numero2 > maior) {
    // ...
}
if (numero3 > maior) {
    // ...
}
```

Ou ainda:

```csharp
if (numero2 > maior) {
    // ...
} else if (numero3 > maior) {
    // ...
}
```
