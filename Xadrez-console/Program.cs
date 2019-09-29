using System;
using tabuleiro;
using xadrez;

namespace Xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);
                    Console.Write("\nOrigem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    bool[,] posiveisPosicoes = partida.tab.peca(origem).movimentosPossiveis();

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, posiveisPosicoes);

                    Console.WriteLine();
                    Console.Write("\nDestino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executarMovimento(origem, destino);
                }
            }
            catch(TabuleiroExcepion e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
