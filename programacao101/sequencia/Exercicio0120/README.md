# Exercício 01.20 - Álcool ou Gasolina?

## Enunciado

Com as constantes variações nos preços dos combustíveis, os motoristas estão sempre em busca da opção mais econômica. Você foi contratado para desenvolver um programa que ajude a resolver esse dilema. O programa deve solicitar o preço por litro do álcool e da gasolina e, com base em uma regra simples de cálculo, indicar qual combustível é mais vantajoso para abastecer.

A regra é a seguinte: se o preço do álcool for menor ou igual a 70% do preço da gasolina, então vale a pena abastecer com álcool. Caso contrário, é melhor optar pela gasolina.

## Entrada

A entrada consiste de duas linhas:

1. O preço por litro do álcool.
2. O preço por litro da gasolina.

## Saída

A saída deve conter uma linha com a indicação do combustível mais vantajoso para abastecer.

## Exemplos

```plaintext
>>>>>>>>
3.59
4.99
========
Vale a pena abastecer com álcool.
<<<<<<<<

>>>>>>>>
3.99
4.99
========
Vale a pena abastecer com gasolina.
<<<<<<<<
```

## Dica

Para determinar qual combustível é mais vantajoso, calcule 70% do preço da gasolina e compare com o preço do álcool. Se o preço do álcool for menor ou igual a esse valor, então o álcool é mais vantajoso.

Em C#, você pode usar `double.Parse(Console.ReadLine())` para ler números decimais e `Console.WriteLine()` para imprimir os resultados.

Lembre-se de usar o comando `if` para verificar a condição e imprimir a resposta correta.

```csharp
double percentual = precoGasolina * 0.7;

if (precoAlcool <= percentual) {
    // ...
}
```
