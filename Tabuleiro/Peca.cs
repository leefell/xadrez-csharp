namespace tabuleiro
{
    internal class Peca
    {

        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; set; }
        public Tabuleiro  tab { get; protected set; }

        public Peca(Posicao posicao, Tabuleiro tab, Cor cor)
        {
            this.posicao = posicao;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0;
        }
    }
}
