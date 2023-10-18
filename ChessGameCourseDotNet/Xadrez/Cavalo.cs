using ChessGameCourseDotNet.Tela;
using ChessGameCourseDotNet.Tabuleiro;
using ChessGameCourseDotNet.Xadrez;
using System;

namespace ChessGameCourseDotNet.Xadrez
{
    public class Cavalo : Peca
    {
        public Cavalo(TabuleiroDeXadrez tabuleiro, Cor cor) : base(tabuleiro, cor) { }

        public override string ToString()
        {
            return "C";
        }

        private bool PodeMover(Posicao posicao)
        {
            Peca peca = TabuleiroDeXadrez.Peca(posicao);
            return peca == null || peca.Cor != Cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] matriz = new bool[TabuleiroDeXadrez.Linhas, TabuleiroDeXadrez.Colunas];

            Posicao posicao = new Posicao(0, 0);

            posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 2);
            if (TabuleiroDeXadrez.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }
            posicao.DefinirValores(Posicao.Linha - 2, Posicao.Coluna - 1);
            if (TabuleiroDeXadrez.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }
            posicao.DefinirValores(Posicao.Linha - 2, Posicao.Coluna + 1);
            if (TabuleiroDeXadrez.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }
            posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 2);
            if (TabuleiroDeXadrez.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }
            posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 2);
            if (TabuleiroDeXadrez.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }
            posicao.DefinirValores(Posicao.Linha + 2, Posicao.Coluna + 1);
            if (TabuleiroDeXadrez.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }
            posicao.DefinirValores(Posicao.Linha + 2, Posicao.Coluna - 1);
            if (TabuleiroDeXadrez.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }
            posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 2);
            if (TabuleiroDeXadrez.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }

            return matriz;
        }
    }
}