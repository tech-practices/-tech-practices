# Exercício 01.16 - Inversão de Números

## Enunciado

Escreva um programa que receba um número no formato Centena-Dezena-Unidade (CDU) e imprima-o invertido, no formato Unidade-Dezena-Centena (UDC). O número deve ser armazenado em outra variável antes de ser impresso.

## Entrada

A entrada consiste de uma linha contendo um número inteiro de três dígitos (CDU).

## Saída

A saída deve conter uma linha com o número invertido (UDC).

## Exemplos

```plaintext
>>>>>>>>
123
========
321
<<<<<<<<

>>>>>>>>
987
========
789
<<<<<<<<
```

## Dica

Para inverter o número, você pode utilizar operações matemáticas para separar cada dígito do número e depois reconstruí-lo na ordem inversa.

Em C#, você pode usar `int.Parse(Console.ReadLine())` para ler o número e `Console.WriteLine()` para imprimir o resultado.

```csharp
int numeroCDU = int.Parse(Console.ReadLine());
int unidade = numeroCDU % 10;
int dezena = (numeroCDU / 10) % 10;
int centena = numeroCDU / 100;
int numeroUDC = unidade * 100 + dezena * 10 + centena;
Console.WriteLine(numeroUDC);
```

## Referências

Problema adaptado de LOPES, Anita; GARCIA, Guto. Introdução à programação: 500 algoritmos resolvidos. Elsevier, 2016. 512 p. ISBN: 9788535285628.
