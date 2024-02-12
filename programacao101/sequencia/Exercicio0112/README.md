# Exercício 01.12 - Cálculo de Velocidade Média

## Enunciado

Escreva um programa que solicite o tempo gasto em uma viagem e a distância percorrida. Em seguida, calcule e imprima a velocidade média da viagem.

## Entrada

A entrada consiste de duas linhas. A primeira linha contém o tempo gasto na viagem (em horas). A segunda linha contém a distância percorrida (em quilômetros).

## Saída

A saída deve conter uma linha com a velocidade média calculada para a viagem (em km/h).

## Exemplos

```plaintext
>>>>>>>>
2
100
========
Velocidade Média: 50 km/h
<<<<<<<<

>>>>>>>>
5
400
========
Velocidade Média: 80 km/h
<<<<<<<<
```

## Dica

A velocidade média é calculada dividindo a distância total percorrida pelo tempo total gasto. A fórmula da velocidade média é:

$$ v_{média} = \frac{d}{t} $$

onde \( v_{média} \) é a velocidade média, \( d \) é a distância percorrida e \( t \) é o tempo gasto.

Em C#, você pode usar `double.Parse(Console.ReadLine())` para ler números decimais e `Console.WriteLine()` para imprimir os resultados.

```csharp
double tempo = double.Parse(Console.ReadLine());
double distancia = double.Parse(Console.ReadLine());
double velocidadeMedia = distancia / tempo;
Console.WriteLine($"Velocidade Média: {velocidadeMedia} km/h");
```
