namespace Computacao
{

    public class Invencao : HistoriaComputacao
    {

        public string DataInvencao;

        public Invencao(string Nome, string Descricao, string DataInvencao) : base(Nome, Descricao)
        {
            this.DataInvencao = DataInvencao;
        }

        public Invencao(string Nome) : base(Nome)
        {
            this.Nome = Nome;
        }
    }

}