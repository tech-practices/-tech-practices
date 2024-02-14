# Exercício 02.08 - Cálculo de Bônus de Funcionário com Switch Case

## Enunciado

Desenvolva um programa em C# que calcule o bônus anual de um funcionário com base em sua classificação de desempenho. O programa deve solicitar o salário atual do funcionário e sua classificação de desempenho. Dependendo da classificação, o bônus será uma porcentagem do salário: 'A' para um bônus de 20%, 'B' para 15%, 'C' para 10%, 'D' para 5% e 'E' para 2%. Qualquer outra classificação não receberá bônus.

## Entrada

A entrada consiste de duas linhas:

1. O salário atual do funcionário.
2. A classificação de desempenho do funcionário ('A', 'B', 'C', 'D', 'E' ou outra).

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
C
========
Valor do bônus: R$ 500.00
<<<<<<<<

>>>>>>>>
5000
F
========
Valor do bônus: R$ 0.00
<<<<<<<<
```

## Dica

Utilize a estrutura `switch case` para aplicar o percentual de bônus correto de acordo com a classificação de desempenho.

```csharp
switch (classificacao) {
    case 'A':
        bonus = salario * 0.20;
        break;
    case 'B':
        bonus = salario * 0.15;
        break;
    // ... assim por diante
    default:
        bonus = 0;
        break;
}
```
