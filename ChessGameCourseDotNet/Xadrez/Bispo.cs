﻿using ChessGameCourseDotNet.Tela;
using ChessGameCourseDotNet.Tabuleiro;
using ChessGameCourseDotNet.Xadrez;
using System;

namespace ChessGameCourseDotNet.Xadrez
{
    public class Bispo : Peca
    {
        public Bispo(TabuleiroDeXadrez tabuleiro, Cor cor) : base(tabuleiro, cor) { }

        public override string ToString() => "B";

        private bool PodeMover(Posicao posicao)
        {
            Peca peca = TabuleiroDeXadrez.Peca(posicao);
            return peca == null || peca.Cor != Cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] matriz = new bool[TabuleiroDeXadrez.Linhas, TabuleiroDeXadrez.Colunas];

            Posicao posicao = new Posicao(0, 0);

            // NO
            posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            while (TabuleiroDeXadrez.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
                if (TabuleiroDeXadrez.Peca(posicao) != null && TabuleiroDeXadrez.Peca(posicao).Cor != Cor)
                {
                    break;
                }
                posicao.DefinirValores(posicao.Linha - 1, posicao.Coluna - 1);
            }

            // NE
            posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            while (TabuleiroDeXadrez.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
                if (TabuleiroDeXadrez.Peca(posicao) != null && TabuleiroDeXadrez.Peca(posicao).Cor != Cor)
                {
                    break;
                }
                posicao.DefinirValores(posicao.Linha - 1, posicao.Coluna + 1);
            }

            // SE
            posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            while (TabuleiroDeXadrez.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
                if (TabuleiroDeXadrez.Peca(posicao) != null && TabuleiroDeXadrez.Peca(posicao).Cor != Cor)
                {
                    break;
                }
                posicao.DefinirValores(posicao.Linha + 1, posicao.Coluna + 1);
            }

            // SO
            posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            while (TabuleiroDeXadrez.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
                if (TabuleiroDeXadrez.Peca(posicao) != null && TabuleiroDeXadrez.Peca(posicao).Cor != Cor)
                {
                    break;
                }
                posicao.DefinirValores(posicao.Linha + 1, posicao.Coluna - 1);
            }
            return matriz;
        }
    }
}