# Exercício 01.02 - Imprimindo uma mensagem e um nome

## Enunciado

Aprendendo a trabalhar com entrada de dados e variáveis.

Escreva um programa que imprima a mensagem "Olá, [nome]!", onde [nome] é o nome do usuário.

## Entradas

O programa não deve receber nenhuma entrada.

## Saídas

O programa deve imprimir a mensagem "Olá, [nome]!", onde [nome] é o nome do usuário.

## Instruções

1. Crie uma variável chamada `nome` e atribua a ela o valor do seu nome;
2. Imprima a mensagem "Olá, [nome]!", substituindo `[nome]` pelo valor da variável `nome`.

## Exemplo

```c#
var nome = "João";
```

Saída:

```plaintext
Olá, João!
```

## Dicas

- Lembre-se de usar o comando `Console.WriteLine` para imprimir a mensagem.
- Você pode usar o operador `+` para concatenar strings com variáveis.
- Você pode usar o operador `$` para criar strings interpoladas, como alternativa.
