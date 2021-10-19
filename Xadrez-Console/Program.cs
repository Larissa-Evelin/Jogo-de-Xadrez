using System;
using tabuleiro;
using xadrez_console;


namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Torre(tab, Cor.Preta), new Tabuleiro(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Tabuleiro(1, 3));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Tabuleiro(2, 4));

            Tela.imprimirTabuleiro(tab);
            Console.ReadLine();

        }
    }
}
