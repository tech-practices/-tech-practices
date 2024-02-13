# Exercício 01.18 - Cálculo de Consumo Energético

## Enunciado

Escreva um programa que calcule o consumo energético de um eletrodoméstico. O usuário deve entrar com a potência do eletrodoméstico (em watts), o tempo de uso diário (em horas) e o número de dias de uso. O sistema deve calcular o consumo total em quilowatt-hora (kWh) e o custo, considerando o valor do kWh.

## Entrada

A entrada consiste de três linhas. A primeira linha contém a potência do eletrodoméstico (em watts). A segunda linha contém o tempo de uso diário (em horas). A terceira linha contém o número de dias de uso.

## Saída

A saída deve conter duas linhas. A primeira linha deve mostrar o consumo total em kWh. A segunda linha deve mostrar o custo, considerando que o valor do kWh é R$ 0,75.

## Exemplos

```plaintext
>>>>>>>>
100
3
30
========
Consumo Total: 9 kWh
Custo: R$ 6,75
<<<<<<<<

>>>>>>>>
1500
2
7
========
Consumo Total: 21 kWh
Custo: R$ 15,75
<<<<<<<<
```

## Dica

Para calcular o consumo total em kWh, multiplique a potência do eletrodoméstico (em watts) pelo tempo de uso diário (em horas) e pelo número de dias de uso. Depois, divida por 1000 para converter de watts para quilowatts. Para calcular o custo, multiplique o consumo total em kWh pelo valor do kWh.

Em C#, você pode usar `double.Parse(Console.ReadLine())` para ler números decimais e `Console.WriteLine()` para imprimir os resultados.

```csharp
double potencia = double.Parse(Console.ReadLine());
double tempoUsoDiario = double.Parse(Console.ReadLine());
double diasUso = double.Parse(Console.ReadLine());
double consumoTotalKWh = (potencia * tempoUsoDiario * diasUso) / 1000;
double custo = consumoTotalKWh * 0.75;
Console.WriteLine($"Consumo Total: {consumoTotalKWh} kWh");
Console.WriteLine($"Custo: R$ {custo:F2}");
```
