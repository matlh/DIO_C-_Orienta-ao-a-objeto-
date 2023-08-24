namespace Computacao
{
    public abstract class HistoriaComputacao
    {
        public string Nome, Descricao;

        public HistoriaComputacao(string Nome, string Descricao)
        {
            this.Nome = Nome;
            this.Descricao = Descricao;
        }

        public HistoriaComputacao(string Nome)
        {
            this.Nome = Nome;
        }
    }
}