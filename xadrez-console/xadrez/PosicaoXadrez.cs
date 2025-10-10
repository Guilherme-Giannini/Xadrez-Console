
using tabuleiro;

namespace xadrez;

public class PosicaoXadrez
{
    public char coluna { get; set; }
    public int linha { get; set; }

    public PosicaoXadrez(char coluna, int linha)
    {
        if (coluna < 'a' || coluna > 'h' || linha < 1 || linha > 8)
        {
            throw new TabuleiroException("Posição inválida no tabuleiro de xadrez!");
        }
        this.coluna = coluna;
        this.linha = linha;
    }
    public Posicao toPosicao()
    {
        return new Posicao(8 - linha, coluna - 'a');
    }

    public override string ToString()
    {
        return "" + coluna + linha;
    }
}
