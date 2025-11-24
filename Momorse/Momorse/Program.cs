using System;

namespace MoMorse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entryN = 0;
            ConsoleKeyInfo Enter;
            List<char> ENTRY = new List<char>();
            string[] LISTM = [".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--",
                "-.", "---", ".--.", "--.-", ".-.", "..." , "-", "..-", "...-", ".--", "-..-", "-.--", "--..", "/"];
            char[] LISTA = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', ' '];
            List<string> ENTRYM = new List<string>();
            List<int> ints = new List<int>();
            Console.WriteLine("=== Couteau Suisse - Utilitaires ===");
            Console.WriteLine("1. Convertir du texte en code Morse");
            Console.WriteLine("2. Convertir des nombres entre différentes bases (Décimal <> Binaire <> Octal)");
            Console.WriteLine("3. (à venir)");
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.D1)
                {
                    Enter = Console.ReadKey();
                    if (Enter.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Morse(ENTRY, key, ENTRYM, LISTA, LISTM);
                    }
                }
                else if(key.Key == ConsoleKey.D2)
                {
                    Enter = Console.ReadKey();
                    if (Enter.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Console.WriteLine("=== Convertisseur de bases ===");
                        Console.WriteLine("1. Décimal > Binaire\r\n2. Binaire > Décimal\r\n3. Binaire > Octal\r\n4. Octal > Binaire\n\n");
                        while (true)
                        {
                            key = Console.ReadKey();
                            if (key.Key == ConsoleKey.D1)
                            {
                                Enter = Console.ReadKey();
                                if (Enter.Key == ConsoleKey.Enter)
                                {
                                    Decabin(key, entryN, ints);
                                    while (true)
                                    {
                                        Enter = Console.ReadKey();
                                        if (Enter.Key == ConsoleKey.Escape)
                                        {
                                            Environment.Exit(0);
                                        }
                                        else if (Enter.Key == ConsoleKey.Enter)
                                        {
                                            if (Enter.Key == ConsoleKey.Enter)
                                            {
                                                Console.Clear();
                                                Main(args);
                                            }
                                        }
                                    }
                                    
                                }
                                else if (Enter.Key == ConsoleKey.Backspace)
                                {
                                    continue;
                                }
                            }
                            else if (key.Key == ConsoleKey.D2)
                            {
                                Enter = Console.ReadKey();
                                if (Enter.Key == ConsoleKey.Enter)
                                {

                                }
                                else if (Enter.Key == ConsoleKey.Backspace)
                                {
                                    continue;
                                }
                            }
                        }
                    }
                }
            }
            static void Morse(List<char> ENTRY, ConsoleKeyInfo key, List<string> ENTRYM, char[] LISTA, string[] LISTM)
            {
                Console.WriteLine("=== Convertisseur de texte en code Morse ===");
                Console.WriteLine("Entrez un mot ou une phrase (sans accents, lettres A-Z) :\n");

                while (true)
                {
                    try
                    {
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.Enter)
                        {
                            break;
                        }
                        else if (key.Key != ConsoleKey.Enter)
                        {
                            if (key.Key == ConsoleKey.Backspace)
                            {
                                if(ENTRY.Count == 0)
                                {
                                    continue;
                                }
                                else
                                {
                                    ENTRY.RemoveAt(ENTRY.Count - 1);
                                }
                            }
                            else if (key.Key != ConsoleKey.Backspace)
                            {
                                ENTRY.Add(char.ToUpper(key.KeyChar));
                            }
                        }
                        Console.Clear();
                        Console.WriteLine("=== Convertisseur de texte en code Morse ===");
                        Console.WriteLine("Entrez un mot ou une phrase (sans accents, lettres A-Z) :\n");
                        for (int i = 0; i < ENTRY.Count; i++)
                        {
                            Console.Write(ENTRY[i]);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Veuillez écrire uniquement des mots");
                    }

                }
                for (int i = 0; i < ENTRY.Count; i++)
                {
                    for (int j = 0; j < LISTA.Length; j++)
                    {
                        if (ENTRY[i] == LISTA[j])
                        {
                            ENTRYM.Add(LISTM[j]);
                        }
                    }
                }

                Console.WriteLine("\nRésultat en Morse : ");
                for (int i = 0; i < ENTRYM.Count; i++)
                {
                    Console.Write(ENTRYM[i]);
                    Console.Write(' '); 
                }

                Console.ReadLine();
            }
            static void Decabin(ConsoleKeyInfo key, int entry, List<int> ints)
            {
                while (true)
                {
                    while (true)
                    {
                        Console.WriteLine("Entrez un nombre décimal à convertir en binaire");
                        try
                        {
                            entry = int.Parse(Console.ReadLine());
                            while (entry != 0)
                            {
                                ints.Add(entry % 2);
                                entry = entry / 2;
                            }
                            break;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Entrez uniquement des chiffres Erreur : ", e.Message);
                        }
                        Console.Clear();
                    }
                    for (int i = ints.Count - 1; i >= 0; i--)
                    {
                        Console.Write(ints[i]);
                    }
                    Console.WriteLine("\n\n Recommencer 'enter' ou quitter ? 'esc'");
                    break;
                }
            }
        }
    }
}