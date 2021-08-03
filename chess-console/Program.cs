using System;
using Tabuleiro;
using Xadrez;
using Tabuleiro.Enums;

namespace chess_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TabuleiroBase tab = new TabuleiroBase(8, 8);
                tab.ColocarPeca(new Torre(Cor.Amarela, tab), new Posicao(2, 7));
                tab.ColocarPeca(new Rei(Cor.Amarela, tab), new Posicao(5, 1));
                tab.ColocarPeca(new Cavalo(Cor.Branca, tab), new Posicao(7, 4));
                tab.ColocarPeca(new Rei(Cor.Branca, tab), new Posicao(4, 4));
                Tela.ImprimirTabuleiro(tab);
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            /*PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());*/
        }
    }
}
