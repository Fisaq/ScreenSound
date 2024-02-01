using System;
using System.Collections.Generic;

class Program
{
    List<string> bandas = new List<string>();

    public static void RegistrarBanda()
    {

    }

    public static void ListarBandas()
    {

    }

    public static void AvaliarBanda()
    {

    }

    public static void MediaNotas()
    {

    }

    public static void Menu()
    {
        int sair = 0;
        int op = 0;

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
                        Console.Write($"Opção {op} escolhida.");
                        sair++;
                        break;
                    case 2:
                        Console.Write($"Opção {op} escolhida.");
                        sair++;
                        break;
                    case 3:
                        Console.Write($"Opção {op} escolhida.");
                        sair++;
                        break;
                    case 4:
                        Console.Write($"Opção {op} escolhida.");
                        sair++;
                        break;
                    case 9:
                        Console.Write($"Opção {op} escolhida.");
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
        string mensagem = "Boas vindas ao Screen Sound!";
        Console.WriteLine(mensagem);
        Menu();
    }
}
