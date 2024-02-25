# Esercício 10.01 - Página Html Básica

Esta é a estrutura de uma página web básica com elementos essenciais para uma navegação eficiente e uma apresentação clara do conteúdo.

## Estrutura do Documento

O documento começa com a declaração `<!DOCTYPE html>` seguida pela tag `<html>` com o atributo `lang="pt-BR"` indicando que o idioma da página é Português do Brasil.

### Cabeçalho do Documento

Dentro da tag `<head>`, temos:

- A tag `<meta charset="UTF-8">` que define a codificação de caracteres para UTF-8.
- A tag `<meta name="viewport" content="width=device-width, initial-scale=1.0">` que assegura a responsividade da página em dispositivos móveis.
- A tag `<title>` que dá título à página, neste caso, "Página Básica".

### Corpo do Documento

O corpo do documento `<body>` contém:

#### Cabeçalho da Página

- Um cabeçalho `<header>` com um título `<h1>` que diz "Minha Página Web".

#### Navegação

- Uma barra de navegação `<nav>` contendo uma lista não ordenada `<ul>` com links para as seções da página: Início, Sobre e Contato.

#### Seções de Conteúdo

- Três seções `<section>` com identificadores únicos: `#home`, `#sobre` e `#contato`.
- Cada seção contém um subtítulo `<h2>` e um parágrafo `<p>` descrevendo o propósito da seção.

#### Rodapé

- Um rodapé `<footer>` com um parágrafo `<p>` contendo direitos autorais.

## Personalização

Você pode personalizar esta estrutura básica adicionando estilos CSS, scripts JavaScript e mais conteúdo conforme necessário para enriquecer a experiência do usuário e atender aos objetivos do seu site.

## Página de Exemplo

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Página Básica</title>
</head>
<body>
    <header>
        <h1>Minha Página Web</h1>
    </header>
    <nav>
        <ul>
            <li><a href="#home">Início</a></li>
            <li><a href="#sobre">Sobre</a></li>
            <li><a href="#contato">Contato</a></li>
        </ul>
    </nav>
    <section id="home">
        <h2>Bem-vindo à Minha Página Web</h2>
        <p>Este é um exemplo de parágrafo na página inicial.</p>
    </section>
    <section id="sobre">
        <h2>Sobre</h2>
        <p>Informações sobre o site ou sobre você.</p>
    </section>
    <section id="contato">
        <h2>Contato</h2>
        <p>Detalhes de como entrar em contato.</p>
    </section>
    <footer>
        <p>© 2024 Minha Página Web</p>
    </footer>
</body>
</html>
```
