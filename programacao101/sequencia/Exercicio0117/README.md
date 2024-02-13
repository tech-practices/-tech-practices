# Exercício 01.17 - Cálculo de Salário MEI

## Enunciado

Escreva um programa que calcule o salário de uma pessoa jurídica na modalidade MEI. O usuário deve entrar com o valor da hora trabalhada e a quantidade de horas trabalhadas no mês. O sistema deve calcular o valor total bruto, os impostos e o valor líquido recebido.

Considere que o imposto sobre o serviço é de 6% sobre o valor bruto.

## Entrada

A entrada consiste de duas linhas. A primeira linha contém o valor da hora trabalhada (em reais). A segunda linha contém a quantidade de horas trabalhadas no mês.

## Saída

A saída deve conter três linhas. A primeira linha deve mostrar o valor total bruto. A segunda linha deve mostrar o valor dos impostos. A terceira linha deve mostrar o valor líquido recebido.

## Exemplos

```plaintext
>>>>>>>>
50
160
========
Valor Bruto: R$ 8000.00
Impostos: R$ 480.00
Valor Líquido: R$ 7520.00
<<<<<<<<

>>>>>>>>
100
180
========
Valor Bruto: R$ 18000.00
Impostos: R$ 1080.00
Valor Líquido: R$ 16920.00
<<<<<<<<
```

## Dica

Para calcular o valor bruto, multiplique o valor da hora pelo número de horas trabalhadas. Para calcular o valor dos impostos, aplique a porcentagem de 6% sobre o valor bruto. Por fim, subtraia o valor dos impostos do valor bruto para obter o valor líquido.

Em C#, você pode usar `double.Parse(Console.ReadLine())` para ler números decimais e `Console.WriteLine()` para imprimir os resultados.

```csharp
double valorHora = double.Parse(Console.ReadLine());
double horasTrabalhadas = double.Parse(Console.ReadLine());
double valorBruto = valorHora * horasTrabalhadas;
double impostos = valorBruto * 0.06;
double valorLiquido = valorBruto - impostos;
Console.WriteLine($"Valor Bruto: R$ {valorBruto:F2}");
Console.WriteLine($"Impostos: R$ {impostos:F2}");
Console.WriteLine($"Valor Líquido: R$ {valorLiquido:F2}");
```
