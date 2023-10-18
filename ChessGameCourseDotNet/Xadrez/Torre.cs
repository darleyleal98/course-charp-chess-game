using ChessGameCourseDotNet.Tela;
using ChessGameCourseDotNet.Tabuleiro;
using ChessGameCourseDotNet.Xadrez;
using System;

namespace ChessGameCourseDotNet.Xadrez
{
    public class Torre : Peca
    {

        public Torre(TabuleiroDeXadrez tabuleiro, Cor cor) : base(tabuleiro, cor) { }

        public override string ToString() => "T";
        private bool podeMover(Posicao posicao)
        {
            Peca peca = TabuleiroDeXadrez.Peca(posicao);
            return peca == null || peca.Cor != Cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] matriz = new bool[TabuleiroDeXadrez.Linhas, TabuleiroDeXadrez.Colunas];

            Posicao posicao = new Posicao(0, 0);

            // acima
            posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            while (TabuleiroDeXadrez.PosicaoValida(posicao) && podeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
                if (TabuleiroDeXadrez.Peca(posicao) != null && TabuleiroDeXadrez.Peca(posicao).Cor != Cor)
                {
                    break;
                }
                posicao.Linha = posicao.Linha - 1;
            }

            // abaixo
            posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            while (TabuleiroDeXadrez.PosicaoValida(posicao) && podeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
                if (TabuleiroDeXadrez.Peca(posicao) != null && TabuleiroDeXadrez.Peca(posicao).Cor != Cor)
                {
                    break;
                }
                posicao.Linha = posicao.Linha + 1;
            }

            // direita
            posicao.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            while (TabuleiroDeXadrez.PosicaoValida(posicao) && podeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
                if (TabuleiroDeXadrez.Peca(posicao) != null && TabuleiroDeXadrez.Peca(posicao).Cor != Cor)
                {
                    break;
                }
                posicao.Coluna = posicao.Coluna + 1;
            }

            // esquerda
            posicao.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            while (TabuleiroDeXadrez.PosicaoValida(posicao) && podeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
                if (TabuleiroDeXadrez.Peca(posicao) != null && TabuleiroDeXadrez.Peca(posicao).Cor != Cor)
                {
                    break;
                }
                posicao.Coluna = posicao.Coluna - 1;
            }

            return matriz;
        }
    }
}