# Exercício 02.10 - Decisão de Rotas de Viagem de Avião

## Enunciado

Desenvolva um programa que determine a melhor rota de avião para um viajante com base em critérios específicos. O programa deve solicitar o destino, se o viajante prefere a rota mais rápida, mais barata ou com menos escalas, e então decidir qual rota escolher utilizando `IF` ou `Switch Case`.

Você deve considerar as seguintes rotas:
'Paris': 7h, R$ 900,00, 1 escala (Rápida) - 12h, R$ 750,00, 2 escalas (Barata) - 10h, R$ 850,00, 1 escala (Menos Escalas)
'Nova York': 15h, R$ 650,00, 3 escalas (Rápida) - 20h, R$ 500,00, 4 escalas (Barata) - 18h, R$ 550,00, 3 escalas (Menos Escalas)
'Tóquio': 20h, R$ 1200,00, Direto (Rápida) - 25h, R$ 1000,00, 1 escala (Barata) - 22h, R$ 1100,00, 1 escala (Menos Escalas)

## Considerações

- O tempo de viagem é representado em horas.
- O custo da viagem é representado em reais.
- O número de escalas é representado por um número inteiro.
- O viajante pode escolher entre 'Rápida', 'Barata' ou 'Menos Escalas'.
- O destino da viagem é representado por uma string.
- Você deverá consistir a entrada do usuário. Caso o destino não esteja disponível, o programa deve informar que o destino não está disponível.
- Você deverá consistir a entrada do usuário. Caso a preferência do viajante não esteja disponível, o programa deve informar que a preferência não está disponível.
- O destino e a preferência do viajante devem ser lidos em linhas separadas.

## Entrada

A entrada consiste de duas linhas:

1. O destino da viagem.
2. A preferência do viajante: 'Rápida', 'Barata' ou 'Menos Escalas'.

## Saída

A saída deve conter uma linha com a descrição da rota escolhida, incluindo duração, custo e número de escalas.

## Exemplos

```plaintext
>>>>>>>>
Paris
Rápida
========
Rota escolhida: Duração 7h - Custo R$ 900,00 - 1 escala
<<<<<<<<

>>>>>>>>
Nova York
Barata
========
Rota escolhida: Duração 20h - Custo R$ 500,00 - 4 escalas
<<<<<<<<

>>>>>>>>
Tóquio
Menos Escalas
========
Rota escolhida: Duração 22h - Custo R$ 1100,00 - 1 escala
<<<<<<<<
```

## Dica

Você pode utilizar múltiplos `ifs` ou `switch case` para verificar a preferência do viajante e então decidir qual rota escolher com base nas informações pré-definidas para cada destino.

Outra dica é, observe que a entrada pode conter acentos, ser maiúscula ou minúscula. Pesquise sobre como a linguagem que você escolheu lida com acentos em Português (pt-BR). Você, também, pode utilizar o método `ToLower()` em C# ou correspondente na lingagem escolhida para converter a entrada do usuário para minúscula e então comparar com as strings pré-definidas. Portanto, leia sobre como a linguagem escolhida trata a comparação de strings.

```csharp
// Exemplo de consistência de entrada
string destino = Console.ReadLine()!.ToLower();
if (destino != "paris" && destino != "nova york" && destino != "tóquio")
{
    Console.WriteLine($"Destino não disponível: {destino}");
    return;
}
```
