using System.Security.Cryptography;
using Computacao;

public class Programa
{
    public static void Main()
    {
        List<Personalidade> P = new List<Personalidade>();
        List<Invencao> I = new List<Invencao>();

         while (true)
        {
            Console.WriteLine("Deseja cadastrar uma Personalidade (digite P) ou invenção (digite I)? (ou digite S para encerrar)");
            string Verificador = Console.ReadLine();
            
            if (Verificador.ToLower() == "s")
            break;

            if(Verificador.ToLower() == "p")
            {
                Console.WriteLine("Digite o nome da Personalidade (ou digite S para encerrar):");
                string Nome = Console.ReadLine();

                if (Nome.ToLower() == "s")
                break;

                Personalidade P1 = new Personalidade(Nome);
                P.Add(P1);
            }

             else if(Verificador.ToLower() == "i")
            {
                Console.WriteLine("Digite o nome da Invenção (ou 'sair' para encerrar):");
                string Nome = Console.ReadLine();

                if (Nome.ToLower() == "s")
                break;

                Invencao I1 = new Invencao(Nome);
                I.Add(I1);
            }

            else
            Console.WriteLine("Digite um parâmetro válido");  
        }

        foreach(Personalidade P1 in P)
        {
            Console.WriteLine("Nome Personalidade: " + P1.Nome);
        }

        foreach(Invencao I1 in I)
        {
            Console.WriteLine("Nome da invenção: " + I1.Nome);
        }
    }
}