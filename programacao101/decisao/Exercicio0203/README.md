# Exercício 02.03 - Comparação de Preços de Produtos

## Enunciado

Desenvolva um programa que ajude os consumidores a comparar preços de produtos em diferentes estabelecimentos. O programa deve receber o nome de um produto, o preço em dois estabelecimentos diferentes e indicar onde o produto é mais barato.

## Entrada

A entrada consiste de três linhas:

1. O nome do produto.
2. O preço do produto no primeiro estabelecimento.
3. O preço do produto no segundo estabelecimento.

## Saída

A saída deve conter uma linha indicando em qual estabelecimento o produto é mais barato.

## Exemplos

```plaintext
>>>>>>>>
Arroz
3.50
3.75
========
O produto Arroz é mais barato no primeiro estabelecimento.
<<<<<<<<

>>>>>>>>
Feijão
4.60
4.40
========
O produto Feijão é mais barato no segundo estabelecimento.
<<<<<<<<
```

## Dica

Utilize uma estrutura de decisão `if` para comparar os preços dos produtos nos dois estabelecimentos. Imprima o nome do estabelecimento onde o produto é mais barato.

```csharp
if (preco1 < preco2) {
    // ...
}
```
