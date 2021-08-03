
using Tabuleiro;
using Tabuleiro.Enums;

namespace Xadrez
{
    class Cavalo : Peca
    {
        public Cavalo(Cor cor, TabuleiroBase tab) : base(cor, tab)
        {

        }

        public override string ToString()
        {
            return "C";
        }
    }
}
