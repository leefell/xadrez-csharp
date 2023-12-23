using tabuleiro;

namespace xadrez
{
    internal class Rei : Peca
    {
        // Rei é uma subclasse de Peca
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
           
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
