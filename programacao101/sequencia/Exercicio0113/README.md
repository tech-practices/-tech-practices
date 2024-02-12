# Exercício 01.13 - Cálculo Geodésico de Distância

## Enunciado

Escreva um programa que solicite duas coordenadas geográficas (latitude e longitude) e calcule a distância geodésica entre elas em quilômetros.

## Entrada

A entrada consiste de quatro linhas. As duas primeiras linhas contêm a latitude e a longitude do primeiro ponto, respectivamente. As duas últimas linhas contêm a latitude e a longitude do segundo ponto, respectivamente.

## Saída

A saída deve conter uma linha com a distância geodésica calculada entre os dois pontos.

## Exemplos

```plaintext
>>>>>>>>
-23.550520
-46.633308
-22.903539
-43.209587
========
A distância entre os pontos é de: 358.172 km
<<<<<<<<
```

## Dica

Para calcular a distância geodésica entre dois pontos na superfície da Terra, você pode usar a fórmula de Haversine:

$$ d = 2r \arcsin\left(\sqrt{\sin^2\left(\frac{\Delta\phi}{2}\right) + \cos(\phi_1)\cos(\phi_2)\sin^2\left(\frac{\Delta\lambda}{2}\right)}\right) $$

onde ![equation](http://latex.codecogs.com/gif.latex?\phi_1) e ![phi_2](http://latex.codecogs.com/gif.latex?\phi_2) são as latitudes dos pontos 1 e 2 em radianos, ![delta_phi](http://latex.codecogs.com/gif.latex?\Delta\phi) é a diferença entre as latitudes, ![delta_lambda](http://latex.codecogs.com/gif.latex?\Delta\lambda) é a diferença entre as longitudes, e r é o raio médio da Terra (aproximadamente 6371 km).

Em C#, você pode usar `Math.Sin()`, `Math.Cos()`, `Math.Asin()`, e `Math.Sqrt()` para realizar os cálculos trigonométricos e `double.Parse(Console.ReadLine())` para ler os números decimais.

```csharp
double lat1 = double.Parse(Console.ReadLine()) * Math.PI / 180;
double lon1 = double.Parse(Console.ReadLine()) * Math.PI / 180;
double lat2 = double.Parse(Console.ReadLine()) * Math.PI / 180;
double lon2 = double.Parse(Console.ReadLine()) * Math.PI / 180;

double deltaLat = lat2 - lat1;
double deltaLon = lon2 - lon1;
double r = 6371;

double a = Math.Sin(deltaLat / 2) * Math.Sin(deltaLat / 2) +
           Math.Cos(lat1) * Math.Cos(lat2) *
           Math.Sin(deltaLon / 2) * Math.Sin(deltaLon / 2);
double c = 2 * Math.Asin(Math.Sqrt(a));
double distance = r * c;

Console.WriteLine($"A distância entre os pontos é de: {distance} km");
```

### Fontes

- (1) github.com. [Drone-simulator](https://github.com/n0bis/healthydrone/tree/30371878d7a76b22f588d0946abacedfac0efb9a/DroneSimulator.API%2FDroneSimulator.API%2FHelpers%2FLatLonSpherical.cs)
- (2) INPE. Calculadora de distância entre dois pontos geográficos. [INPE](https://www.dpi.inpe.br/calcula/)
- (3) Wikipedia. Haversine formula. [Wikipedia](https://en.wikipedia.org/wiki/Haversine_formula)
- (4) Stackoverflow. Haversine formula in C#. [Stackoverflow](https://stackoverflow.com/questions/27928/calculate-distance-between-two-latitude-longitude-points-haversine-formula)
