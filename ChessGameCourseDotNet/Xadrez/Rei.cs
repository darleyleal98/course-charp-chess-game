using ChessGameCourseDotNet.Tela;
using ChessGameCourseDotNet.Tabuleiro;
using ChessGameCourseDotNet.Xadrez;
using System;

namespace ChessGameCourseDotNet.Xadrez
{
    public class Rei : Peca
    {
        private PartidaDeXadrez Partida;

        public Rei(TabuleiroDeXadrez tabuleiro, Cor cor, PartidaDeXadrez partida) : base(tabuleiro, cor)
        {
            Partida = partida;
        }
        public override string ToString() => "R";
        private bool podeMover(Posicao posica)
        {
            Peca peca = TabuleiroDeXadrez.Peca(posica);
            return peca == null || peca.Cor != Cor;
        }
        private bool testeTorreParaRoque(Posicao posicao)
        {
            Peca peca = TabuleiroDeXadrez.Peca(posicao);
            return peca != null && peca is Torre && peca.Cor == Cor && peca.QuantidadeDeMovimentos == 0;
        }
        public override bool[,] MovimentosPossiveis()
        {
            bool[,] matriz = new bool[TabuleiroDeXadrez.Linhas, TabuleiroDeXadrez.Colunas];

            Posicao posicao = new Posicao(0, 0);

            // acima
            posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            if (TabuleiroDeXadrez.PosicaoValida(posicao) && podeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }
            // ne
            posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            if (TabuleiroDeXadrez.PosicaoValida(posicao) && podeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }
            // direita
            posicao.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            if (TabuleiroDeXadrez.PosicaoValida(posicao) && podeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }
            // se
            posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            if (TabuleiroDeXadrez.PosicaoValida(posicao) && podeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }
            // abaixo
            posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            if (TabuleiroDeXadrez.PosicaoValida(posicao) && podeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }
            // so
            posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            if (TabuleiroDeXadrez.PosicaoValida(posicao) && podeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }
            // esquerda
            posicao.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            if (TabuleiroDeXadrez.PosicaoValida(posicao) && podeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }
            // no
            posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            if (TabuleiroDeXadrez.PosicaoValida(posicao) && podeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }

            // #jogadaespecial roque
            if (QuantidadeDeMovimentos == 0 && !Partida.xeque)
            {
                // #jogadaespecial roque pequeno
                Posicao posicaoT1 = new Posicao(Posicao.Linha, Posicao.Coluna + 3);
                if (testeTorreParaRoque(posicaoT1))
                {
                    Posicao posicao1 = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
                    Posicao posicao2 = new Posicao(Posicao.Linha, Posicao.Coluna + 2);
                    if (TabuleiroDeXadrez.Peca(posicao1) == null && TabuleiroDeXadrez.Peca(posicao2) == null)
                    {
                        matriz[Posicao.Linha, Posicao.Coluna + 2] = true;
                    }
                }
                // #jogadaespecial roque grande
                Posicao posicaoT2 = new Posicao(Posicao.Linha, Posicao.Coluna - 4);
                if (testeTorreParaRoque(posicaoT2))
                {
                    Posicao posicao1 = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
                    Posicao posicao2 = new Posicao(Posicao.Linha, Posicao.Coluna - 2);
                    Posicao posicao3 = new Posicao(Posicao.Linha, Posicao.Coluna - 3);
                    if (TabuleiroDeXadrez.Peca(posicao1) == null && TabuleiroDeXadrez.Peca(posicao2) == null && TabuleiroDeXadrez.Peca(posicao3) == null)
                    {
                        matriz[Posicao.Linha, Posicao.Coluna - 2] = true;
                    }
                }
            }
            return matriz;
        }
    }
}