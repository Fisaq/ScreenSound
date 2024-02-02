using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Program
{
    static List<string> bandas = new List<string>();
    static Dictionary<string,int> notaBandas = new Dictionary<string,int>();

    public static void RegistrarBanda(string nomeBanda)
    {
        bandas.Add(nomeBanda);
        Console.Write($"{nomeBanda} registrada!");
    }

    public static void ListarBandas()
    {
        Console.Write("\n---------- BANDAS CADASTRADAS ---------\n");
        for (int i = 0; i < bandas.Count; i++) {
            Console.Write($"\n{bandas[i]}");
        }
    }

    public static void AvaliarBanda(string nomeBanda, int notaBanda)
    {
        notaBandas[nomeBanda] = notaBanda;

        for (int i = 0; i < bandas.Count;i++)
        {
            if (notaBandas[nomeBanda].Equals(bandas[i]))
            {
                Console.Write($"{bandas[i]} recebeu uma nova nota, {notaBanda}");
            }
        }
    }

    public static void MediaNotas()
    {

    }

    public static void Menu()
    {
        int sair = 0;
        int op;

        while (sair < 1)
        {
            Console.WriteLine("\n---------- MENU ----------\n");

            Console.Write("[1] Registrar uma banda\n[2] Listar bandas\n" +
              "[3] Avaliar uma banda\n[4] Exibir média\n\n[9] Sair\n\nR: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out op))
            {
                switch (op)
                {
                    case 1:

                        Console.Write("\nInforme o nome da banda que deseja registrar: ");
                        string nomeBanda = Console.ReadLine();

                        RegistrarBanda(nomeBanda);

                        break;
                    case 2:

                        ListarBandas();
                        break;

                    case 3:

                        Console.Write("\nQual banda você deseja avaliar? ");
                        nomeBanda = Console.ReadLine();

                        Console.Write("\nNota:  ");
                        int nota = int.Parse(Console.ReadLine());

                        AvaliarBanda(nomeBanda, nota);

                        break;
                    case 4:

                        Console.Write($"Opção {op} escolhida.");
                        sair++;

                        break;
                    case 9:

                        Console.Write("Fim do Programa!");
                        sair++;

                        break;
                    default:

                        Console.Write("Opção inválida");

                        break;
                }
            }
        }
    }

    public static void Main()
    {
        StreamReader logo;

        string caminho = ".\logo.txt";

        logo = File.OpenText(caminho);

        string[] lerLinhas = File.ReadAllLines(caminho);

        for (int c = 0; c < lerLinhas.Length; c++)
        {
            Console.WriteLine(lerLinhas[c]);
        }

        logo.Close();

        string mensagem = "Boas vindas ao Screen Sound!";
        Console.WriteLine(mensagem);
        Menu();
    }
}
