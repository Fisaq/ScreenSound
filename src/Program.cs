using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static Dictionary<string, List<int>> notasPorBanda = new Dictionary<string, List<int>>();

    public static void RegistrarBanda(string nomeBanda)
    {
        if (notasPorBanda.ContainsKey(nomeBanda))
        {
            Console.WriteLine($"A banda {nomeBanda} já está registrada.");
        }
        else
        {
            notasPorBanda[nomeBanda] = new List<int>();
            Console.WriteLine($"{nomeBanda} registrada com sucesso!");
        }
    }

    public static void ListarBandas()
    {
        Console.Write("\n---------- BANDAS CADASTRADAS ---------\n");
        foreach (string banda in notasPorBanda.Keys)
        {
            Console.WriteLine(banda);
        }
    }

    public static void AvaliarBanda(string nomeBanda, int notaBanda)
    {
        if (notasPorBanda.ContainsKey(nomeBanda))
        {
            notasPorBanda[nomeBanda].Add(notaBanda);
            Console.WriteLine($"Banda {nomeBanda} avaliada com sucesso.");
        }
        else
        {
            Console.WriteLine("A banda {nomeBanda} ainda não foi registrada. Favor registra-la antes de avaliar.");
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

        string caminho = "logo.txt";

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
