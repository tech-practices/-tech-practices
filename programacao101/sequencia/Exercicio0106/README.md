# Exercício 01.06 - Soma de Números Intercalados

## Enunciado

Escreva um programa que leia, em sequência, dois pares de números e, logo depois, imprima a soma de cada par no seguinte formato:

```csharp
"Soma1: {soma1}"
"Soma2: {soma2}"
```

## Entrada

A entrada consiste de quatro linhas. As duas primeiras linhas contêm o primeiro e o segundo número do primeiro par (números inteiros), e as duas últimas linhas contêm o primeiro e o segundo número do segundo par (números inteiros).

## Saída

A saída consiste de duas linhas, cada uma contendo a soma de um par de números.

## Exemplos

```plaintext
>>>>>>>>
3
7
15
10
========
Soma1: 10
Soma2: 25
<<<<<<<<
```

## Dica

Você precisará ler números inteiros do teclado e somá-los. Em C#, você pode usar `int.Parse(Console.ReadLine())` para converter a entrada em um número inteiro e realizar a soma.

```csharp
int numero1 = int.Parse(Console.ReadLine());
int numero2 = int.Parse(Console.ReadLine());
Console.WriteLine($"Soma1: {numero1 + numero2}");
int numero3 = int.Parse(Console.ReadLine());
int numero4 = int.Parse(Console.ReadLine());
Console.WriteLine($"Soma2: {numero3 + numero4}");
```
