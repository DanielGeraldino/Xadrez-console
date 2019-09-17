using System;
using tabuleiro;
using xadrez;

namespace Xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            /*PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());*/

            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Rei(tab, Cor.preto), new Posicao(0,5));
            tab.colocarPeca(new Rei(tab, Cor.branco), new Posicao(7, 2));

            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
