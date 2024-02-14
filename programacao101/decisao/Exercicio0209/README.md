# Exercício 02.09 - Cálculo de Bônus com Classificação de Desemempenho e Tempo de Serviço

## Enunciado

Desenvolva um programa em C# que calcule o bônus anual de um funcionário com base em sua classificação de desempenho e tempo de serviço. O programa deve solicitar o salário atual do funcionário, sua classificação de desempenho e o número de anos trabalhados na empresa. O bônus é calculado como uma porcentagem do salário: 'A' para 20%, 'B' para 15%, 'C' para 10%, 'D' para 5% e 'E' para 2%. Além disso, funcionários com mais de 5 anos de serviço recebem um bônus adicional de 5%.

## Entrada

A entrada consiste de três linhas:

1. O salário atual do funcionário.
2. A classificação de desempenho do funcionário ('A', 'B', 'C', 'D', 'E' ou outra).
3. O número de anos trabalhados na empresa.

## Saída

A saída deve conter uma linha com o valor do bônus a ser recebido.

## Exemplos

```plaintext
>>>>>>>>
5000
A
6
========
Valor do bônus: R$ 1250.00
<<<<<<<<

>>>>>>>>
5000
C
3
========
Valor do bônus: R$ 500.00
<<<<<<<<

>>>>>>>>
5000
F
10
========
Valor do bônus: R$ 250.00
<<<<<<<<
```

## Dica

Uma das possibilidades é o uso de `ifs` aninhados para verificar primeiro a classificação de desempenho e, dentro de cada condição, verifique o tempo de serviço para aplicar o bônus adicional. Porém, o código pode ficar com verificações desnecessárias. Tente pensar em uma forma de simplificar o código.

```csharp
if (classificacao == 'A') {
    bonus = salario * 0.20;
    if (anosServico > 5) {
        bonus += salario * 0.05;
    }
} else if (classificacao == 'B') {
    bonus = salario * 0.15;
    if (anosServico > 5) {
        bonus += salario * 0.05;
    }
} else if (classificacao == 'C') {
    bonus = salario * 0.10;
    if (anosServico > 5) {
        bonus += salario * 0.05;
    }
} else if (classificacao == 'D') {
    bonus = salario * 0.05;
    if (anosServico > 5) {
        bonus += salario * 0.05;
    }
} else if (classificacao == 'E') {
    bonus = salario * 0.02;
    if (anosServico > 5) {
        bonus += salario * 0.05;
    }
} else {
    bonus = 0;
    if (anosServico > 5) {
        bonus = salario * 0.05;
    }
}

Console.WriteLine($"Valor do bônus: R$ {bonus:F2}");
```
