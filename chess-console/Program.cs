using System;
using Tabuleiro;

namespace chess_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao p = new Posicao(2, 2);
            TabuleiroBase tab = new TabuleiroBase(16, 16);
            Console.WriteLine(p);
        }
    }
}
