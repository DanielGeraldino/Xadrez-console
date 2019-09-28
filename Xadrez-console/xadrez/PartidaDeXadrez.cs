using System;
using tabuleiro;
namespace xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool terminada { get; private set; }

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.branco;
            terminada = false;
            colocarPeca();
        }

        public void executarMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementaQtdMovimento();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
        }

        public void colocarPeca()
        {
            tab.colocarPeca(new Torre(tab, Cor.preto), new PosicaoXadrez('c',1).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.preto), new PosicaoXadrez('c', 2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.preto), new PosicaoXadrez('d', 2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.preto), new PosicaoXadrez('e', 2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.preto), new PosicaoXadrez('e', 1).toPosicao());
            tab.colocarPeca(new Rei(tab, Cor.preto), new PosicaoXadrez('d', 1).toPosicao());

            tab.colocarPeca(new Torre(tab, Cor.branco), new PosicaoXadrez('c', 7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.branco), new PosicaoXadrez('c', 8).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.branco), new PosicaoXadrez('d', 7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.branco), new PosicaoXadrez('e', 7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.branco), new PosicaoXadrez('e', 8).toPosicao());
            tab.colocarPeca(new Rei(tab, Cor.branco), new PosicaoXadrez('d', 8).toPosicao());
        }

    }
}
