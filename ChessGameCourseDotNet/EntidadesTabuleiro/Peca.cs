using ChessGameCourseDotNet.Tabuleiro;
using ChessGameCourseDotNet.Xadrez;

namespace ChessGameCourseDotNet.Tabuleiro
{
    public abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QuantidadeDeMovimentos { get; protected set; }
        public TabuleiroDeXadrez TabuleiroDeXadrez { get; protected set; }

        public Peca(TabuleiroDeXadrez tabuleiro, Cor cor)
        {
            Posicao = null;
            TabuleiroDeXadrez = tabuleiro;
            Cor = cor;
            QuantidadeDeMovimentos = 0;
        }

        public void IncrementarQuantidadeDeMovimentos() => QuantidadeDeMovimentos++;

        public void DecrementarQuantidadeDeMovimentos() => QuantidadeDeMovimentos--;

        public bool ExisteMovimentosPossiveis()
        {
            bool[,] matriz = MovimentosPossiveis();
            for (int i = 0; i < TabuleiroDeXadrez.Linhas; i++)
            {
                for (int j = 0; j < TabuleiroDeXadrez.Colunas; j++)
                {
                    if (matriz[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool MovimentoPossivel(Posicao posicao)
        {
            return MovimentosPossiveis()[posicao.Linha, posicao.Coluna];
        }

        public abstract bool[,] MovimentosPossiveis();
    }
}