using System;

namespace MoMorse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int EntryN;
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
                                    while (true)
                                    {
                                        //Console.WriteLine("Entrez un nombre décimal à convertir en binaire");
                                        //try
                                        //{
                                        //    bool isNumber = int.TryParse(Console.ReadLine(), out EntryN);
                                        //    for (int i = 0; 
                                        //}
                                        //catch (Exception e)
                                        //{
                                        //    Console.WriteLine("Entrez uniquement des chiffres");
                                        //}
                                    }
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
                        if (key.Key == ConsoleKey.Enter)
                        {
                            break;
                        }
                        else if (key.Key == ConsoleKey.Backspace)
                        {
                            ENTRY.RemoveAt(ENTRY.Count - 1);
                            Console.Clear();
                            Console.WriteLine("=== Convertisseur de texte en code Morse ===");
                            Console.WriteLine("Entrez un mot ou une phrase (sans accents, lettres A-Z) :\n");
                            for (int i = 0; i < ENTRY.Count; i++)
                            {
                                Console.Write(ENTRY[i]);
                            }
                        }
                        else if (key.Key != ConsoleKey.Backspace || key.Key != ConsoleKey.Enter)
                        {
                            key = Console.ReadKey();
                            ENTRY.Add(char.ToUpper(key.KeyChar));
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
        }
    }
}