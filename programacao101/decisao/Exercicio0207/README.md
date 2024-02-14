# Exercício 02.07 - Cálculo de Bônus de Funcionário

## Enunciado

Desenvolva um programa que calcule o bônus anual de um funcionário com base em seu desempenho. O programa deve solicitar o salário atual do funcionário e sua classificação de desempenho. Dependendo da classificação, o bônus será uma porcentagem do salário: 'A' para um bônus de 20%, 'B' para 15% e 'C' para 10%. Qualquer outra classificação não receberá bônus.

## Entrada

A entrada consiste de duas linhas:

1. O salário atual do funcionário.
2. A classificação de desempenho do funcionário ('A', 'B', 'C' ou outra).

## Saída

A saída deve conter uma linha com o valor do bônus a ser recebido.

## Exemplos

```plaintext
>>>>>>>>
5000
A
========
Valor do bônus: R$ 1000.00
<<<<<<<<

>>>>>>>>
5000
B
========
Valor do bônus: R$ 750.00
<<<<<<<<

>>>>>>>>
5000
D
========
Valor do bônus: R$ 0.00
<<<<<<<<
```

## Dica

Utilize as estruturas condicionais `if`, `else if` e `else` para aplicar o percentual de bônus correto de acordo com a classificação de desempenho. Existem várias formas de resolver este problema, avalie o uso de `if` e `else` aninhados ou `if` e `else if` para resolver o problema.
