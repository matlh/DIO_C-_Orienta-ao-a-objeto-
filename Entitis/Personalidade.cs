namespace Computacao
{
    public class Personalidade : HistoriaComputacao
    {
        public string DataNascimento; 

        public Personalidade(string Nome, string Descricao, string DataNascimento) : base(Nome, Descricao)
        {
            this.DataNascimento = DataNascimento;
        }

        public Personalidade(string Nome) : base(Nome)
        {
            this.Nome = Nome;
        }

        public override string ToString()
        {
            return "Nome:\n"+ this.Nome + "\n\nData de nascimento\n" + this.DataNascimento;
        }
    }
}