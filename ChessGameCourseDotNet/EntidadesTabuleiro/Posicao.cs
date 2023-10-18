using ChessGameCourseDotNet.Tabuleiro;
using ChessGameCourseDotNet.Xadrez;
using System.Text;

namespace ChessGameCourseDotNet.Tabuleiro
{
    public class Posicao
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Posicao(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }

        public void DefinirValores(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"{Linha}, {Coluna}");
            return stringBuilder.ToString();
        }
    }
}