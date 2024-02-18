# Exercício 02.11 - Escolha de Assento em Voo

## Enunciado

Desenvolva um programa que ajude um passageiro a escolher o melhor assento em um voo com base em suas preferências. O programa deve solicitar o tipo de assento que o passageiro prefere (janela, corredor ou meio) e se deseja mais espaço para as pernas. Com base nessas informações, o programa deve utilizar `IF` ou `Switch Case` para determinar o assento a ser escolhido.

Considere as seguintes opções de assentos:

- Janela: Normal (R$ 300,00) - Espaço Extra (R$ 350,00)
- Corredor: Normal (R$ 280,00) - Espaço Extra (R$ 330,00)
- Meio: Normal (R$ 250,00) - Espaço Extra (R$ 300,00)

## Considerações

- O custo do assento é representado em reais.
- O passageiro pode escolher entre 'Janela', 'Corredor' ou 'Meio'.
- O passageiro pode escolher entre 'Normal' ou 'Espaço Extra' para mais conforto.
- O tipo de assento e a preferência por espaço extra devem ser lidos em linhas separadas.
- Você deverá consistir a entrada do usuário. Caso o tipo de assento ou a preferência por espaço extra não estejam disponíveis, o programa deve informar que a opção não está disponível.

## Entrada

A entrada consiste de duas linhas:

1. O tipo de assento desejado: 'Janela', 'Corredor' ou 'Meio'.
2. A preferência por espaço: 'Normal' ou 'Espaço Extra'.

## Saída

A saída deve conter uma linha com a descrição do assento escolhido, incluindo o tipo de assento e o custo.

## Exemplos

```plaintext
>>>>>>>>
Janela
Espaço Extra
========
Assento escolhido: Janela - Espaço Extra - Custo R$ 350,00
<<<<<<<<

>>>>>>>>
Corredor
Normal
========
Assento escolhido: Corredor - Normal - Custo R$ 280,00
<<<<<<<<

>>>>>>>>
Meio
Normal
========
Assento escolhido: Meio - Normal - Custo R$ 250,00
<<<<<<<<
```

## Dica

Utilize `ifs` aninhados ou `switch case` para verificar primeiro o tipo de assento e, dentro de cada condição, verifique a preferência por espaço para determinar o custo final. Lembre-se de tratar a entrada do usuário para aceitar variações de maiúsculas e minúsculas, bem como acentos, utilizando métodos apropriados da linguagem escolhida.

```csharp
// Exemplo de consistência de entrada
string tipoAssento = Console.ReadLine()!.ToLower();
string preferenciaEspaco = Console.ReadLine()!.ToLower();

if (tipoAssento != "janela" && tipoAssento != "corredor" && tipoAssento != "meio")
{
    Console.WriteLine($"Tipo de assento não disponível: {tipoAssento}");
    return;
}

if (preferenciaEspaco != "normal" && preferenciaEspaco != "espaço extra")
{
    Console.WriteLine($"Preferência por espaço não disponível: {preferenciaEspaco}");
    return;
}
```

Outra dica é pesquisar sobre operadores ternários para simplificar a exibição da saída. Pesquise sobre o operador `?` e `:` em C# e outras linguagens de programação.

```csharp
valor = (preferenciaEspaco == "normal") ? 300 : 350;
```
