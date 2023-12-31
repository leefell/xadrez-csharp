﻿using tabuleiro;

namespace xadrez
{

    // Essa classe é pra auxiliar a pensar como o xadrez normal

    internal class PosicaoXadrez
    {
        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        public Posicao toPosicao()
        {
            // O objetivo desse método é converter a posição que o usuário jogou para 
            // a posição comum da matriz

            return new Posicao(8 - linha, coluna - 'a');
        }
        public override string ToString()
        {
            return "" + coluna + linha;
        }
    }
}
