# Exercício 01.08 - Cálculo do Custo de Viagem

## Enunciado

Escreva um programa que solicite o nome de uma cidade, a distância desde a sua casa até a cidade, quantos quilômetros por litro seu carro faz e o valor do litro de gasolina. Em seguida, calcule o custo da viagem em combustível e imprima o resultado.

## Entrada

A entrada consiste de quatro linhas. A primeira linha contém o nome da cidade. A segunda linha contém a distância até a sua casa (em quilômetros). A terceira linha contém a eficiência do carro (em quilômetros por litro). A quarta linha contém o valor do litro de gasolina (em reais).

## Saída

A saída deve conter duas linhas. A primeira linha deve mostrar o nome da cidade e a segunda linha deve mostrar o custo da viagem em combustível.

## Exemplos

```plaintext
>>>>>>>>
Belo Horizonte
300
10
5.30
========
Cidade: Belo Horizonte
Custo da Viagem: R$ 159.00
<<<<<<<<
```

## Dica

Para resolver esse problema, você precisará realizar cálculos matemáticos simples. Primeiro, calcule a quantidade de litros de gasolina necessária para a viagem, dividindo a distância pela eficiência do carro. Depois, multiplique a quantidade de litros pelo valor do litro de gasolina para obter o custo total da viagem.

Em C#, você pode usar `double.Parse(Console.ReadLine())` para ler números decimais e `Console.WriteLine()` para imprimir os resultados.

```csharp
string cidade = Console.ReadLine();
double distancia = double.Parse(Console.ReadLine());
double kmPorLitro = double.Parse(Console.ReadLine());
double valorLitroGasolina = double.Parse(Console.ReadLine());
double custoViagem = (distancia / kmPorLitro) * valorLitroGasolina;
Console.WriteLine($"Cidade: {cidade}");
Console.WriteLine($"Custo da Viagem: R$ {custoViagem:F2}");
```
