using System;
using Tabuleiro;
using Tabuleiro.Enums;
using System.Collections.Generic;

namespace Xadrez
{
    class PartidaDeXadrez
    {
        public TabuleiroBase Tab { get; private set; }
        public int Turno { get; private set; }
        public Cor JogadorAtual { get; private set; }
        public bool Terminada { get; private set; }
        private HashSet<Peca> Pecas;
        private HashSet<Peca> Capturadas;

        public PartidaDeXadrez()
        {
            Tab = new TabuleiroBase(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            Terminada = false;
            Pecas = new HashSet<Peca>();
            Capturadas = new HashSet<Peca>();
            ColocarPecas();
        }

        public void ExecutarMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Tab.RetirarPeca(origem);
            p.IncrementarMovimento();
            Peca PecaCapturada = Tab.RetirarPeca(destino);
            Tab.ColocarPeca(p, destino);
            if (PecaCapturada != null)
            {
                Capturadas.Add(PecaCapturada);
            }
        }

        private void MudarJogador()
        {
            if (JogadorAtual == Cor.Branca)
            {
                JogadorAtual = Cor.Preta;
            }
            else
            {
                JogadorAtual = Cor.Branca;
            }
        }

        public HashSet<Peca> PecasCapturadas(Cor cor)
        {
            HashSet<Peca> aux = new HashSet<Peca>();

            foreach (Peca x in Capturadas )
            {
                if (x.Cor == cor)
                {
                    aux.Add(x);
                }
            }
            return aux;
        }

        public HashSet<Peca> PecasEmJogo(Cor cor)
        {
            HashSet<Peca> aux = new HashSet<Peca>();

            foreach (Peca x in Pecas)
            {
                if (x.Cor == cor)
                {
                    aux.Add(x);
                }
            }
            aux.ExceptWith(PecasCapturadas(cor));
            return aux;
        }

        public void ValidadrPosicaoDeOrigem(Posicao pos)
        {
            if (Tab.Peca(pos) == null)
            {
                throw new TabuleiroException("Não existe peça na posição origem escolhida!");
            }
            if (JogadorAtual != Tab.Peca(pos).Cor)
            {
                throw new TabuleiroException("A peça escolhida não é sua!");
            }
            if (!Tab.Peca(pos).ExisteMovimentosPossiveis())
            {
                throw new TabuleiroException("Não esxiste movimentos possiveis para a peça escolhida!");
            }
        }

        public void ValidarPosicaoDeDestino(Posicao origem, Posicao destino)
        {
            if (!Tab.Peca(origem).PodeMoverPara(destino))
            {
                throw new TabuleiroException("Posição de destino invalida!");
            }
        }

        public void RealizarJogada(Posicao origem, Posicao destino)
        {
            ExecutarMovimento(origem, destino);
            Turno++;
            MudarJogador();

        }
        public void ColocarNovaPeca(char coluna, int linha, Peca peca)
        {
            Tab.ColocarPeca(peca, new PosicaoXadrez(coluna, linha).ToPosicao());
            Pecas.Add(peca);
        }

        private void ColocarPecas()
        {
            ColocarNovaPeca('a', 8, new Torre(Cor.Preta, Tab));
            ColocarNovaPeca('h', 8, new Torre(Cor.Preta, Tab));
            ColocarNovaPeca('e', 8, new Rei(Cor.Preta, Tab));
            ColocarNovaPeca('g', 8, new Cavalo(Cor.Preta, Tab));
            ColocarNovaPeca('b', 8, new Cavalo(Cor.Preta, Tab));
            ColocarNovaPeca('f', 8, new Bispo(Cor.Preta, Tab));
            ColocarNovaPeca('c', 8, new Bispo(Cor.Preta, Tab));

            ColocarNovaPeca('a', 1, new Torre(Cor.Branca, Tab));
            ColocarNovaPeca('h', 1, new Torre(Cor.Branca, Tab));
            ColocarNovaPeca('e', 1, new Rei(Cor.Branca, Tab));
            ColocarNovaPeca('b', 1, new Cavalo(Cor.Branca, Tab));
            ColocarNovaPeca('g', 1, new Cavalo(Cor.Branca, Tab));
        }
    }
}
