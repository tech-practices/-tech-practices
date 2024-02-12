# Exercício 01.03 - Multiplas entradas

## Enunciado

Escreva um programa que leia, em sequencia, dois nomes, coloque-os em duas variáveis e, logo depois imprima-os na tela, no seguinte formato:

```c#
"Nome1: {nome1}"
"Nome2: {nome2}"
```

## Entrada

A entrada consiste de duas linhas, cada uma contendo um nome.

## Saída

A saída consiste de duas linhas, cada uma contendo um nome.

## Exemplos

```c#
>>>>>>>>
Ana
Maria
========
Nome1: Ana
Nome2: Maria
<<<<<<<<
```

```c#

## Dica

Pesquise na linguagem desejada como ler uma string do teclado e utilize a função correspondente à impressão para imprimir as strings na tela.

Em C#, por exemplo, seria:

```c#
string nome1 = Console.ReadLine();
Console.WriteLine($"Nome1: {nome1}");
```
