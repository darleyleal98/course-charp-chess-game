using System;
using ChessGameCourseDotNet.Tabuleiro;
using ChessGameCourseDotNet.Xadrez;

namespace ChessGameCourseDotNet.Tabuleiro
{
    public class TabuleiroException : Exception
    {
        public TabuleiroException(string mensagem) : base(mensagem) { }
    }
}