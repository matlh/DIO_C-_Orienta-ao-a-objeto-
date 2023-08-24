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
            Console.WriteLine("\nDeseja cadastrar uma Personalidade (digite 'P') ou invenção (digite 'I')? (ou digite 'S' para finalizar cadastro)");
            string Verificador = Console.ReadLine();
            
            if (Verificador.ToLower() == "s")
            break;

            if(Verificador.ToLower() == "p")
            {
                Console.WriteLine("\nDigite o nome da Personalidade (ou digite 'S' para finalizar cadastro):");
                string Nome = Console.ReadLine();

                Console.WriteLine("\nDigite a data de nascimento da Personalidade (ou digite 'S' para finalizar cadastro):");
                string DataNascimetno = Console.ReadLine();

                Console.WriteLine("\nDigite uma descrição da Personalidade (ou digite 'S' para finalizar cadastro):");
                string Descricao = Console.ReadLine();

                if (Nome.ToLower() == "s" | DataNascimetno.ToLower() == "s" | Descricao.ToLower() == "s")
                break;

                Personalidade P1 = new Personalidade(Nome, Descricao, DataNascimetno);
                P.Add(P1);
            }

             else if(Verificador.ToLower() == "i")
            {
                Console.WriteLine("\nDigite o nome da Invenção (ou 'sair' para encerrar):");
                string Nome = Console.ReadLine();

                Console.WriteLine("\nDigite a data da Invenção (ou 'sair' para encerrar):");
                string Data = Console.ReadLine();

                Console.WriteLine("\nDigite uma descrição para Invenção (ou 'sair' para encerrar):");
                string Descricao = Console.ReadLine();

                if (Nome.ToLower() == "s" | Data.ToLower() == "s" | Descricao.ToLower() == "s")
                break;

                Invencao I1 = new Invencao(Nome, Descricao, Data);
                I.Add(I1);
            }

            else
            Console.WriteLine("\nDigite um parâmetro válido");  
        }

        Console.WriteLine("\nLista de personalidades cadastradas\n");
        foreach (Personalidade P1 in P)
        Console.WriteLine(P1.ToString());

        Console.WriteLine("\nLista de invenções cadastradas\n");
        foreach (Invencao I1 in I)
        Console.WriteLine(I1.ToString());
    }
}