# Exercício 01.19 - Hidratação Ideal para Funcionários

## Enunciado

A empresa ACME Ltda, pensando no bem-estar de seus funcionários, deseja ajudá-los a se hidratarem melhor. Para isso, você foi contratado para desenvolver um aplicativo em que calcule a quantidade ideal de água que cada funcionário deve ingerir diariamente.

O programa deve solicitar o nome do funcionário, o peso atual em kg e a quantidade de água já ingerida no dia em litros. Com essas informações, o programa calculará a quantidade ideal de água a ser ingerida, baseando-se na fórmula de 35 ml de água por quilo por dia, e informará quanto ainda falta para atingir essa meta.

## Entrada

A entrada consiste de três linhas:

1. O nome do funcionário.
2. O peso do funcionário em kg.
3. A quantidade de água já ingerida no dia em litros.

## Saída

A saída deve conter:

1. O nome do funcionário.
2. O peso do funcionário.
3. A quantidade de água já ingerida.
4. A quantidade ideal de água a ingerir.
5. Uma mensagem indicando se o funcionário atingiu a meta de hidratação diária ou quanto ainda falta para atingi-la.

## Exemplos

```plaintext
>>>>>>>>
Carlos
80
1.5
========
Nome: Carlos
Peso: 80Kg
Quantidade de água ingerida: 1.5 litros
Quantidade ideal de água a ingerir: 2.8 litros
Continue focado em se hidratar por hoje, ainda faltam 1.3 litros! Você consegue!
<<<<<<<<
```

## Dica

Para calcular a quantidade ideal de água a ingerir, multiplique o peso do funcionário por 35 ml e divida por 1000 para converter para litros. Subtraia a quantidade já ingerida para saber quanto ainda falta para atingir a meta.

Em C#, você pode usar `double.Parse(Console.ReadLine())` para ler números decimais e `Console.WriteLine()` para imprimir os resultados.

Para fazer o controle e seleção do fluxo de execução, você pode usar a estrutura `if` e `else` para verificar se a quantidade a ingerir é menor ou igual a zero e imprimir a mensagem correspondente.

```csharp
if (quantidadeAIngerir <= 0) {
    Console.WriteLine("Parabéns, você atingiu a meta de hidratação diária!");
} else {
    Console.WriteLine($"Continue focado em se hidratar por hoje, ainda faltam {quantidadeAIngerir} litros! Você consegue!");
}
```
