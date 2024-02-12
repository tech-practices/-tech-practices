# Exercício 01.03 - Nomes e Idades

## Enunciado

Escreva um programa que leia, em sequência, dois nomes e duas idades, coloque-os em quatro variáveis e, logo depois, imprima-os na tela no seguinte formato:

```csharp
"Nome1: {nome1}, Idade1: {idade1}"
"Nome2: {nome2}, Idade2: {idade2}"
```

## Entrada

A entrada consiste de quatro linhas. As duas primeiras linhas contêm um nome cada, e as duas últimas linhas contêm uma idade cada (números inteiros).

## Saída

A saída consiste de duas linhas, cada uma contendo um nome e uma idade.

## Exemplos

```plaintext
>>>>>>>>
Ana
Maria
30
25
========
Nome1: Ana, Idade1: 30
Nome2: Maria, Idade2: 25
<<<<<<<<
```

## Dica

Além de ler strings do teclado, você precisará ler números inteiros. Em C#, você pode usar `int.Parse(Console.ReadLine())` para converter a entrada em um número inteiro.

```csharp
string nome1 = Console.ReadLine();
int idade1 = int.Parse(Console.ReadLine());
Console.WriteLine($"Nome1: {nome1}, Idade1: {idade1}");
```
