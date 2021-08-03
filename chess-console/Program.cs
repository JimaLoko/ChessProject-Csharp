using System;
using Tabuleiro;

namespace chess_console
{
    class Program
    {
        static void Main(string[] args)
        {
            TabuleiroBase tab = new TabuleiroBase(8, 8);
            Tela.imprimirTabuleiro(tab);
            //Console.WriteLine(p);
        }
    }
}
