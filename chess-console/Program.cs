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
            /*try
            {
                TabuleiroBase tab = new TabuleiroBase(8, 8);
                tab.ColocarPeca(new Torre(Cor.Amarela, tab), new Posicao(2, 55));
                tab.ColocarPeca(new Rei(Cor.Amarela, tab), new Posicao(5, 1));
                tab.ColocarPeca(new Cavalo(Cor.Amarela, tab), new Posicao(7, 4));
                Tela.imprimirTabuleiro(tab);
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }*/
            PosicaoXadrez posicaoXadrez = new PosicaoXadrez('c', 7);
            Console.WriteLine(posicaoXadrez);
            Console.WriteLine(posicaoXadrez.toPosicao());
        }
    }
}
