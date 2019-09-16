﻿using System;
using tabuleiro;
using xadrez;

namespace Xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Rei(tab, Cor.preto), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.preto), new Posicao(1, 3));

            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
