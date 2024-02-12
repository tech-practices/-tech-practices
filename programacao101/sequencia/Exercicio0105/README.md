# Exercício 01.05 - Nomes e Idades Intercalados (Variação)

## Enunciado

Escreva um programa que leia, em sequência, um nome e uma idade, e depois outro nome e outra idade, coloque-os em quatro variáveis e, logo depois, imprima-os na tela no seguinte formato:

```csharp
"Nome1: {nome1}, Idade1: {idade1}"
"Nome2: {nome2}, Idade2: {idade2}"
```

## Entrada

A entrada consiste de quatro linhas intercaladas. A primeira linha contém o primeiro nome, a segunda linha contém a idade do primeiro nome (número inteiro), a terceira linha contém o segundo nome, e a quarta linha contém a idade do segundo nome (número inteiro).

## Saída

A saída consiste de duas linhas, cada uma contendo um nome e uma idade correspondente.

## Exemplos

```plaintext
>>>>>>>>
Ana
30
Maria
25
========
Nome1: Ana, Idade1: 30
Nome2: Maria, Idade2: 25
<<<<<<<<
```

## Dica

Você precisará alternar entre ler strings e números inteiros do teclado. Em C#, você pode usar `int.Parse(Console.ReadLine())` para converter a entrada de idade em um número inteiro.

```csharp
string nome1 = Console.ReadLine();
int idade1 = int.Parse(Console.ReadLine());
string nome2 = Console.ReadLine();
int idade2 = int.Parse(Console.ReadLine());
Console.WriteLine($"Nome1: {nome1}, Idade1: {idade1}");
Console.WriteLine($"Nome2: {nome2}, Idade2: {idade2}");
```
