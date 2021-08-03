using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiro;
using Tabuleiro.Enums;

namespace Xadrez
{
    class Rei : Peca
    {
        public Rei(Cor cor, TabuleiroBase tab) : base(cor, tab)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
