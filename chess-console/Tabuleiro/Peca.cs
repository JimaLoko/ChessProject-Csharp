﻿
using Tabuleiro.Enums;

namespace Tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtMovimentos { get; protected set; }
        public TabuleiroBase Tabuleiro { get; protected set; }

        public Peca(Cor cor, TabuleiroBase tabuleiro)
        {
            Posicao = null;
            Cor = cor;
            Tabuleiro = tabuleiro;
            QtMovimentos = 0;
        }

        public void IncrementarMovimento()
        {
            QtMovimentos++;
        }
    }
}
