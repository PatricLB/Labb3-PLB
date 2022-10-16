using System.Collections.Generic;
using System.Runtime.CompilerServices;
using WordsLibrary;

namespace Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                string[] choices = new string[7]
                {"-lists",
                "-new <list name> <language 1> <language 2> .. <langauge n>",
                "-add <list name>",
                "-remove <list name> <language> <word 1> <word 2> .. <word n>",
                "-words <listname> <sortByLanguage>",
                "-count <listname>",
                "-practice <listname>"};

                System.Console.WriteLine("Use any of the following parameters: ");
                foreach (string choice in choices)
                {
                    System.Console.WriteLine(choice);
                }

            }
            else
            {
                string name = "example2";
                string[] languages = new string[2] { "Svenska", "Engelska" };
                var ordlista = new WordList(name, languages);

                ListaListor();
                var ord = WordList.LoadList("Svenska2");

                System.Console.WriteLine(ListaAntalOrd(ord));
                System.Console.WriteLine(ListaAntalOrd(ordlista));

                // System.Console.WriteLine("Andra språket i translation: " + ord.Languages[1]);
                ord.Add(languages);
               // System.Console.WriteLine($"Ladda lista: {WordList.LoadList("example3").Languages[0]}");

            }

            //ordlista.Save();
            //ordlista2.Save();
        }

        public static void ListaListor()
        {
            string[] listor = WordList.GetLists();
            foreach (string lista in listor)
            {
                System.Console.WriteLine(lista);

            }
        }
        public static string ListaAntalOrd(WordList ordlista)
        {
            int antalOrd = ordlista.Count();
            if (antalOrd == -1 || antalOrd == 0)
            {
                return "Inga ord i listan";
            }
            else
            {
                return $"Antal ord: {antalOrd}";
            }
        }
    }
}