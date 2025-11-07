using System;

namespace MoMorse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> ENTRY = new List<char>();
            string[] LISTM = [".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--",
                "-.", "---", ".--.", "--.-", ".-.", "..." , "-", "..-", "...-", ".--", "-..-", "-.--", "--..", "/"];
            char[] LISTA = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', ' '];
            List<string> ENTRYM = new List<string>();
            Console.WriteLine("=== Convertisseur de texte en code Morse ===");
            Console.WriteLine("Entrez un mot ou une phrase (sans accents, lettres A-Z) :\n");

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                try
                {
                    ENTRY.Add(key.KeyChar);
                    if (key.Key == ConsoleKey.Enter)
                    {
                        break;
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

            Console.WriteLine("Résultat en Morse : ");
            for (int i = 0; i < ENTRYM.Count; i++)
            { 
                Console.Write(ENTRYM[i]);
            }

            
        }
    }
}