
using Tabuleiro;
using Tabuleiro.Enums;

namespace Xadrez
{
    class Bispo : Peca
    {
        public Bispo(Cor cor, TabuleiroBase tab) : base(cor, tab)
        {

        }
        public override bool[,] MovimentosPossiveis()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return "B";
        }
    }
}
