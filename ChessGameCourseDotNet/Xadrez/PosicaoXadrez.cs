using ChessGameCourseDotNet.Tela;
using ChessGameCourseDotNet.Tabuleiro;
using ChessGameCourseDotNet.Xadrez;
using System;

namespace ChessGameCourseDotNet.Xadrez
{
    public class PosicaoXadrez
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }
        public PosicaoXadrez(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }
        public Posicao ToPosicao()
        {
            return new Posicao(8 - Linha, Coluna - 'a');
        }
        public override string ToString() => $" {Coluna} {Linha}";
    }
}