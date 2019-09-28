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

                    Console.WriteLine("\nOrigem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.WriteLine("\nDestino: ");
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
