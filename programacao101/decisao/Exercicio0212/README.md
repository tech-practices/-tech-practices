# Exercício 02.12 - Cálculo de Categoria por Idade

## Enunciado

Desenvolva um programa que determine a categoria de participação de um atleta em uma competição com base em sua idade. O programa deve solicitar a data de nascimento do atleta e a data atual, calcular a idade e, em seguida, utilizar `IF` ou `Switch Case` para decidir a categoria do atleta.

Considere as seguintes categorias:

- Infantil: até 10 anos.
- Juvenil: de 11 a 17 anos.
- Adulto: de 18 a 59 anos.
- Sênior: 60 anos ou mais.

## Considerações

- A data de nascimento e a data atual devem ser inseridas no formato `dd/mm/aaaa`.
- O programa deve calcular a idade do atleta na data atual.
- Você deverá consistir a entrada do usuário. Caso a data de nascimento seja inválida ou a data atual seja anterior à data de nascimento, o programa deve informar que a data é inválida.

## Entrada

A entrada consiste de uma linha:

1. A data de nascimento do atleta.

## Saída

A saída deve conter uma linha com a categoria do atleta.

## Exemplos

```plaintext
>>>>>>>>
12/03/2012
========
O atleta tem 11 anos e está na categoria Juvenil
<<<<<<<<

>>>>>>>>
22/07/2005
========
O atleta tem 18 anos e está na categoria Adulto
<<<<<<<<

>>>>>>>>
30/11/1980
========
O atleta tem 43 anos e está na categoria Adulto
<<<<<<<<

>>>>>>>>
01/06/1950
========
Categoria: Sênior
<<<<<<<<
```

## Dica

Utilize a função de data da linguagem escolhida para calcular a idade do atleta na data atual. Em seguida, utilize `ifs` aninhados ou `switch case` para determinar a categoria com base na idade calculada. Lembre-se de validar as datas de entrada e de tratar possíveis exceções. Outra dica é verificar como a linguagem escolhida lida com formatos de datas, lembre-se que o formato de entrada é `dd/MM/yyyy` e a data pode variar de acordo com a cultura do sistema operacional.

No C# existe uma classe chamada `DateTime` que possui um método chamado `TryParseExact` que permite a conversão de uma string para um objeto `DateTime` com base em um formato específico. O método retorna `true` se a conversão for bem-sucedida e `false` caso contrário. O método `TryParseExact` possui os seguintes parâmetros:

```csharp
DateTime.TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style, out DateTime result);
```

Contudo, existem outras formas de realizar a conversão de uma string para um objeto `DateTime`. Pesquise sobre as opções disponíveis na linguagem escolhida.

Outra dica é que a data atual pode ser obtida utilizando a propriedade `DateTime.Now` da classe `DateTime`.

```csharp
DateTime dataAtual = DateTime.Now;
```

Por fim, fique atento à forma de calcular a idade do atleta. Lembre-se que a idade é dada pela diferença entre a data atual e a data de nascimento. A classe `DateTime` possui um método chamado `Subtract` que permite calcular a diferença entre duas datas. O método `Subtract` retorna um objeto `TimeSpan` que possui a propriedade `Days` que retorna a diferença entre as datas em dias. A partir da diferença em dias, é possível calcular a idade do atleta. Pegar apeas a diferença dos anos pode não ser suficiente, pois o atleta pode ainda não ter feito aniversário.

```csharp
DateTime dataNascimento = new DateTime(2000, 12, 31);
DateTime dataAtual = DateTime.Now;
TimeSpan diferenca = dataAtual.Subtract(dataNascimento);
int idade = diferenca.Days / 365;
```
