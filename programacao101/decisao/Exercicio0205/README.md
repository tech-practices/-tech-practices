# Exercício 02.05 - Classificação de Triângulos

## Enunciado

Desenvolva um programa que classifique um triângulo como equilátero, isósceles ou escaleno. O programa deve solicitar os comprimentos dos três lados do triângulo e, com base nesses valores, determinar o tipo de triângulo formado.

## Entrada

A entrada consiste de três linhas:

1. O comprimento do primeiro lado do triângulo.
2. O comprimento do segundo lado do triângulo.
3. O comprimento do terceiro lado do triângulo.

## Saída

A saída deve conter uma linha informando se o triângulo é equilátero, isósceles ou escaleno.

## Exemplos

```plaintext
>>>>>>>>
5
5
5
========
Triângulo Equilátero.
<<<<<<<<

>>>>>>>>
5
5
7
========
Triângulo Isósceles.
<<<<<<<<

>>>>>>>>
5
6
7
========
Triângulo Escaleno.
<<<<<<<<
```

## Dica

Utilize a estrutura condicional `if` para verificar se todos os lados são iguais (equilátero), apenas dois lados são iguais (isósceles) ou se todos os lados são diferentes (escaleno).

Pesquise sobre triângulos equiláteros, isósceles e escalenos para entender as condições de cada um.
