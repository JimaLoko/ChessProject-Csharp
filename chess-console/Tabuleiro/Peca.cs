
using Tabuleiro.Enums;

namespace Tabuleiro
{
    abstract class Peca
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
        public void DecrementarMovimento()
        {
            QtMovimentos--;
        }

        public bool ExisteMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();
            for (int i = 0; i < Tabuleiro.Linhas; i++)
            {
                for (int j = 0; j < Tabuleiro.Colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;

        }

        public bool PodeMoverPara(Posicao pos)
        {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];
        }

        public abstract bool[,] MovimentosPossiveis();
    }
}
