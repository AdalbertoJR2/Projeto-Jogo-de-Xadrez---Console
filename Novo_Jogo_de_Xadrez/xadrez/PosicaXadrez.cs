﻿using System;
using tabuleiro;

namespace xadrez
{
    class PosicaXadrez
    {
        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        } 

        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a');
        }

        public override string ToString()
        {
            return "" + linha + coluna;
        }
    }
}
