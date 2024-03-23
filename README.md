# Jogo de Xadrez em Console

- Este é um projeto de jogo de xadrez desenvolvido em C# para ser jogado no console. Desenvolvido no curso 'C# COMPLETO Programação Orientada a Objetos + Projetos' oferecido na Udemy pelo profesor Nélio Alves.
---
### Objetivo

- O objetivo do projeto é execitar à Orietação à objetos, usando conceitos como estrutura de dados, herança, polimorfismo, composição, enumeração, coleções, tratamento de exceções, sobreposições, métodos e classes abstratas entre outros.
---
## Descrição

O projeto foi dividido em namespaces para gerenciar a estrutura básica do tabuleiro e a lógica do jogo de xadrez. Abaixo estão as principais classes e suas funcionalidades:

### Namespace: tabuleiro

- **Cor**: Enumeração que define as cores das peças, sendo elas Branca ou Preta.
- **Posicao**: Representa uma posição no tabuleiro com linhas e colunas.
- **Tabuleiro**: Classe que define a estrutura do tabuleiro, permitindo colocar e retirar peças.
- **TabuleiroException**: Exceção personalizada para erros relacionados ao tabuleiro.
- **Peca**: Classe abstrata que serve como base para as peças do jogo.

## Namespace: xadrez

- **PartidaDeXadrez**: Classe que gerencia a partida de xadrez, incluindo a lógica de movimentação das peças e validações de jogadas.
- **PosicaoXadrez**: Classe auxiliar que permite converter uma posição no formato do xadrez para a posição na matriz do tabuleiro.
- **Rei**: Classe que representa a peça Rei com suas regras de movimentação.
- **Torre**: Classe que representa a peça Torre com suas regras de movimentação.
- **Bispo**: Classe que representa a peça Bispo com suas regras de movimentação, movendo-se na diagonal.
- **Cavalo**: Classe que representa a peça Cavalo com suas regras de movimentação, movendo-se em forma de "L".
- **Dama**: Classe que representa a peça Dama, também conhecida como Rainha, com suas regras de movimentação que combinam movimentos de torre e bispo.
- **Peao**: Classe que representa a peça Peão com suas regras de movimentação, incluindo movimentos básicos, captura e promoção.

## Funcionalidades

- Posicionamento de peças no tabuleiro.
- Lógica de movimentação para as peças.
- Validações para movimentos possíveis e jogadas.
- Jogadas especias implementadas.

## Como executar

Para executar:

1. Tenha um ambiente de desenvolvimento C# configurado.
2. Clone o repositório.
3. Compile e execute o projeto.
4. Siga as instruções no console para jogar, usando as regras básicas do xadrez.

## Lições

- Geral: Esse projeto atualmente foi o mais longo em que trabalhei, usei diversos conceitos da orientação à objetos, entendendo sua necessidade e motivo de existir.

- Dificuldades: Ao iniciar o projeto, enfrentei desafios significativos relacionados à abstração de conceitos e à minha falta de familiaridade com o xadrez. No entanto, vi essa situação como uma oportunidade para me desafiar. Esta experiência não apenas ampliou meu entendimento sobre abstração e lógica, mas também me motivou a aprender sobre o jogo de xadrez.

## Contribuindo

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou pull requests para aprimorar o projeto.
