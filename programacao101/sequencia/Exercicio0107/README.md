# Exercício 01.07 - Soma e Média de Idades

## Enunciado

Escreva um programa que leia seis nomes e seis idades correspondentes, armazene-os em variáveis e, em seguida, calcule a soma e a média das idades. Por fim, imprima todos os nomes com suas respectivas idades, a soma total e a média das idades.

## Entrada

A entrada consiste de doze linhas. As linhas ímpares contêm os nomes, e as linhas pares contêm as idades correspondentes (números inteiros).

## Saída

A saída deve conter oito linhas. As seis primeiras linhas devem conter cada nome seguido pela idade correspondente. A sétima linha deve mostrar a soma total das idades, e a oitava linha deve mostrar a média das idades.

## Exemplos

```plaintext
>>>>>>>>
João
25
Maria
22
Pedro
30
Ana
28
Lucas
19
Clara
33
========
João: 25
Maria: 22
Pedro: 30
Ana: 28
Lucas: 19
Clara: 33
Soma das Idades: 157
Média das Idades: 26.17
<<<<<<<<
```

## Dica

Problemas computacionais, em sua maioria, são resolvidos em passos. Primeiro, você precisa ler os nomes e as idades. Depois, você precisa calcular a soma e a média das idades. Por fim, você precisa imprimir os resultados.

Existem informações que estão externas ao problema que podem te ajudar a resolvê-lo. Por exemplo, para calcular a média das idades, saber o que é média aritmética. É preciso, portanto, procurar o conhecimento das bases da resolução do problema, nesse caso, como calcular uma média.

Para calcular a média das idades, você precisará somar todas as idades e depois dividir pelo número total de idades (neste caso, 6). Em C#, você pode usar `int.Parse(Console.ReadLine())` para ler as idades e `Console.WriteLine()` para imprimir os resultados.

No caso do C#, o operador `/` faz a divisão de dois números inteiros e retorna um número inteiro. Para que a divisão retorne um número decimal, você pode dividir por um número decimal, como `6.0`.

```csharp
int idade1 = int.Parse(Console.ReadLine());
int idade2 = int.Parse(Console.ReadLine());
int idade3 = int.Parse(Console.ReadLine());
// ... e assim por diante
int soma = idade1 + idade2 + idade3 + ...;
double media = soma / 6.0;
```
