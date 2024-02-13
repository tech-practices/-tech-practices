# Exercício 02.06 - Cálculo de Tarifa de Energia

## Enunciado

Desenvolva um programa que calcule o valor da tarifa de energia elétrica a ser paga pelo consumidor. O programa deve solicitar o consumo em quilowatt-hora (kWh) e aplicar uma tarifa diferenciada de acordo com o consumo: até 100 kWh aplica um desconto de 15%, de 101 a 200 kWh aplica um desconto de 10%, e acima de 200 kWh utiliza-se a tarifa cheia. O valor da tarifa é de R$ 0,85 por kWh. Ao final, o programa deve exibir o valor da tarifa a ser paga.

## Entrada

A entrada consiste de uma linha:

1. O consumo em quilowatt-hora (kWh).

## Saída

A saída deve conter uma linha com o valor da tarifa a ser paga.

## Exemplos

```plaintext
>>>>>>>>
80
========
Valor da tarifa: R$ 57.80
<<<<<<<<

>>>>>>>>
150
========
Valor da tarifa: R$ 114,75
<<<<<<<<

>>>>>>>>
250
========
Valor da tarifa: R$ 212.50
<<<<<<<<
```

## Dica

Utilize a estrutura condicional `if` para aplicar o desconto correto de acordo com o consumo informado. Lembre-se de aplicar o desconto sobre o valor total do consumo.

Para calcacular o percentual de um valor, basta multiplicar o valor pelo percentual dividido por 100. Por exemplo, para calcular 10% de um valor `x`, basta multiplicar `x` por `0.10`. Se for descotno de 10%, basta multiplicar por `0.90`.

```csharp
tarifa *= 0.90; // Desconto de 10%
tarifa *= 0.95; // Desconto de 5%
```
