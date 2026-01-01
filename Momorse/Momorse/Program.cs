using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MoMorse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int power = 1;
            int power2 = 0;
            int entryN = 0;
            ConsoleKeyInfo Enter;
            List<char> ENTRY = new List<char>();
            List<string> ENTRYM = new List<string>();
            List<int> ints = new List<int>();
            List<int> octoints = new List<int>();
            Console.WriteLine("=== Couteau Suisse - Utilitaires ===");
            Console.WriteLine("1. Convertir du texte en code Morse");
            Console.WriteLine("2. Convertir des nombres entre différentes bases (Décimal <> Binaire <> Octal)");
            Console.WriteLine("3. Convertir du texte en code César");
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.D1)
                {
                    Enter = Console.ReadKey();
                    if (Enter.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Morse(ENTRY, ENTRYM);
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
                }
                else if (key.Key == ConsoleKey.D2)
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
                                    Console.WriteLine(Binadec(Enter, ints, entryN, power, power2));
                                    Console.WriteLine("\n\n Recommencer 'enter' ou quitter ? 'esc'");
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
                            else if (key.Key == ConsoleKey.D3)
                            {
                                Enter = Console.ReadKey();
                                if (Enter.Key == ConsoleKey.Enter)
                                {
                                    Binaoct(Binadec(Enter, ints, entryN, power, power2), octoints);
                                    Console.WriteLine("\n\n Recommencer 'enter' ou quitter ? 'esc'");
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
                            }
                            else if (key.Key == ConsoleKey.D4)
                            {
                                Enter = Console.ReadKey();
                                if (Enter.Key == ConsoleKey.Enter)
                                {
                                    Octabin(Enter, octoints);
                                    Console.WriteLine("\n\n Recommencer 'enter' ou quitter ? 'esc'");
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
                            }
                        }
                    }
                }
                else if (key.Key == ConsoleKey.D3)
                {
                    Enter = Console.ReadKey();
                    if (Enter.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        //Caesar(LISTA, ENTRY, key, entryN);
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
                }
            }
        }
        static void Morse(List<char> ENTRY, List<string> ENTRYM)
        {
            ENTRY.Clear();
            ENTRYM.Clear();
            
            string[] LISTM = [".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--",
                "-.", "---", ".--.", "--.-", ".-.", "..." , "-", "..-", "...-", ".--", "-..-", "-.--", "--..", "-----",".----","..---","...--","....-",".....", "-....", "--...", "---..", "----.", "/"];
            char[] LISTA = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ' '];
            Console.Clear();
            Console.WriteLine("=== Convertisseur de texte en code Morse ===");
            Console.WriteLine("Entrez un mot ou une phrase (sans accents, lettres A-Z, chiffres 0-9) :\n");

            while (true)
            { 
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter && ENTRY.Count > 0)
                {
                    break;
                }
                else if (key.Key == ConsoleKey.Backspace)
                {
                    if (ENTRY.Count > 0)
                        ENTRY.RemoveAt(ENTRY.Count - 1);
                }
                else
                {
                    char c = char.ToUpper(key.KeyChar);
                    if (char.IsLetterOrDigit(c) || c == ' ')
                    {
                        ENTRY.Add(c);   
                    }
                    else
                    {
                        Console.WriteLine("\nCaractère invalide (lettres A-Z ou chiffres 0-9 seulement)");
                        continue;
                    }
                }
                
                Console.Clear();
                Console.WriteLine("=== Convertisseur de texte en code Morse ===");
                Console.WriteLine("Entrez un mot ou une phrase (sans accents, lettres A-Z, chiffres 0-9) :\n");
                Console.Write(string.Join("", ENTRY));
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
            Console.WriteLine(string.Join(" ", ENTRYM));

            Console.WriteLine("\n\n Recommencer 'enter' ou quitter ? 'esc'");
        }
        static void Decabin(ConsoleKeyInfo key, int entry, List<int> ints)
        {
            while (true)
            {
                while (true)
                {
                    Console.WriteLine("Entrez un nombre décimal à convertir en binaire : ");
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
                        Console.Clear();
                        Console.WriteLine("Entrez uniquement des chiffres");
                    }
                }
                for (int i = ints.Count - 1; i >= 0; i--)
                {
                    Console.Write(ints[i]);
                }
                Console.WriteLine("\n\n Recommencer 'enter' ou quitter ? 'esc'");
                break;
            }
        }
        static int Binadec(ConsoleKeyInfo Enter, List<int> ints, int entryN, int power, int power2)
        {
            while (true)
            {
                Console.WriteLine("\rEntrez un nombre binaire : ");
                for (int i = 0; i < ints.Count; i++)
                {
                    Console.Write(ints[i]);
                }
                Enter = Console.ReadKey();
                if (Enter.Key == ConsoleKey.Enter)
                {
                    for (int i = ints.Count - 1; i >= 0; i--)
                    {
                        entryN += ints[i] * power;
                        power = 1;
                        if (power2 < 2)
                        {
                            power2++;
                        }
                        else
                        {
                            power2 *= 2;
                        }
                        power *= 2 * power2;
                    }
                    break;
                }
                else if (Enter.Key == ConsoleKey.Backspace)
                {
                    if (ints.Count == 0)
                    {
                        continue;
                    }
                    else
                    {
                        Console.Clear();
                        ints.RemoveAt(ints.Count - 1);
                    }
                }
                else if (Enter.Key == ConsoleKey.D0 || Enter.Key == ConsoleKey.D1)
                {
                    ints.Add(Enter.Key - ConsoleKey.D0);
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Format incorrect");
                    continue;
                }

            }
            Console.WriteLine();
            return entryN;

        }
        static void Binaoct(int EntryD, List<int> ints)
        {
            while (EntryD != 0)
            {
                ints.Add(EntryD % 8);
                EntryD /= 8;
            }
            for (int i = ints.Count - 1; i >= 0; i--)
            {
                Console.Write(ints[i]);
            }
        }
        static void Octabin(ConsoleKeyInfo Enter, List<int> octoints)
        {
            Console.WriteLine("\rEntrez un nombre octal : ");
            for (int i = 0; i < octoints.Count; i++)
            {
                Console.Write(octoints[i]);
            }
            while (true)
            {
                Enter = Console.ReadKey();
                if (Enter.Key == ConsoleKey.Enter)
                {
                    string binaryResult = "";
                    foreach (int digit in octoints)
                    {
                        switch (digit)
                        {
                            case 0:
                                binaryResult += "000";
                                break;
                            case 1:
                                binaryResult += "001";
                                break;
                            case 2:
                                binaryResult += "010";
                                break;
                            case 3:
                                binaryResult += "011";
                                break;
                            case 4:
                                binaryResult += "100";
                                break;
                            case 5:
                                binaryResult += "101";
                                break;
                            case 6:
                                binaryResult += "110";
                                break;
                            case 7:
                                binaryResult += "111";
                                break;
                        }
                    }
                    Console.WriteLine("\nRésultat en binaire : " + binaryResult);
                    break;
                }
                else if (Enter.Key == ConsoleKey.Backspace)
                {
                    if (octoints.Count == 0)
                    {
                        continue;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("=== Convertisseur de bases ===");
                        Console.WriteLine("1. Décimal > Binaire\r\n2. Binaire > Décimal\r\n3. Binaire > Octal\r\n4. Octal > Binaire\n\n");
                        Console.WriteLine("\rEntrez un nombre octal : ");
                        octoints.RemoveAt(octoints.Count - 1);
                        for (int i = 0; i < octoints.Count; i++)
                        {
                            Console.Write(octoints[i]);
                        }
                    }
                }
                else if (Enter.Key >= ConsoleKey.D0 && Enter.Key <= ConsoleKey.D7)
                {
                    octoints.Add(Enter.Key - ConsoleKey.D0);
                    Console.Clear();
                    Console.WriteLine("=== Convertisseur de bases ===");
                    Console.WriteLine("1. Décimal > Binaire\r\n2. Binaire > Décimal\r\n3. Binaire > Octal\r\n4. Octal > Binaire\n\n");
                    Console.WriteLine("\rEntrez un nombre octal : ");
                    for (int i = 0; i < octoints.Count; i++)
                    {
                        Console.Write(octoints[i]);
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Format incorrect (chiffres 0-7 uniquement)");
                    Console.WriteLine("\rEntrez un nombre octal : ");
                    for (int i = 0; i < octoints.Count; i++)
                    {
                        Console.Write(octoints[i]);
                    }
                    continue;
                }
            }
        }
        static void Caesar(char[] LISTA, List<char> ENTRY, ConsoleKeyInfo key, int entry)
        {
            Console.WriteLine("=== Convertisseur de texte en code César ===");
            Console.WriteLine("Entrez un mot ou une phrase (sans accents, lettres A-Z) :\n");
            while (true)
            {
                key = Console.ReadKey(true);

                try
                {
                    if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                    else if (key.Key == ConsoleKey.Backspace)
                    {
                        if (ENTRY.Count > 0)
                            ENTRY.RemoveAt(ENTRY.Count - 1);
                    }
                    else
                    {
                        char c = char.ToUpper(key.KeyChar);

                        if (!char.IsLetter(c) && c != ' ')
                        {
                            Console.WriteLine("\nCaractère invalide (lettres A-Z seulement)");
                            continue;
                        }

                        ENTRY.Add(c);
                    }
                    Console.Clear();
                    Console.WriteLine("=== Convertisseur de texte en code César ===");
                    Console.WriteLine("Entrez un mot ou une phrase (sans accents, lettres A-Z) :\n");

                    for (int i = 0; i < ENTRY.Count; i++)
                    {
                        Console.Write(ENTRY[i]);
                    }
                }

                catch
                {
                    Console.WriteLine("Erreur : veuillez écrire uniquement des mots.");
                }
            }
            while (true)
            {
                Console.WriteLine("\nMettez une clé pour le décalage (chiffres)");
                try
                {
                    entry = int.Parse(Console.ReadLine());
                    for (int i = 0; i <= ENTRY.Count; i++)
                    {
                        for (int j = 0; j < LISTA.Length; j++)
                        {
                            if (ENTRY[i] == ' ')
                            {
                                Console.Write(' ');
                                continue;
                            }
                            else if (ENTRY[i] == LISTA[j])
                            {
                                if (j + 3 > 26)
                                {
                                    j = j + 3 - 26;

                                }
                                Console.Write(LISTA[j + entry]);
                                break;
                            }
                        }
                    }
                    break;

                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Mettez uniquement des chiffres pour la clé de décalage");
                }
            }
        }
    }
}