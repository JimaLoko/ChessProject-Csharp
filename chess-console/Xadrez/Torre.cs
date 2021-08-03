
using Tabuleiro;
using Tabuleiro.Enums;

namespace Xadrez
{
    class Torre : Peca
    {
        public Torre(Cor cor, TabuleiroBase tab) : base(cor, tab)
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}
