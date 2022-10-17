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
                string[] språk = new string[2] { "Engelska", "Svenska" };
                ListaListor();
                var ord = WordList.LoadList("example2");
               // System.Console.WriteLine($"Current list is: {ord.Name}");

                // Så här skall consoleprogrammet skicka in datan.
                var ordLista = new WordList("ExempelPåLista2", "Engelska", "Svenska", "Tyska");
                System.Console.WriteLine($"Current list is: {ordLista.Name}");
                //ordLista.Add();
                //ordLista.Save();

                SkapaLista(ordLista.Name, ordLista.Languages);
                läggTillOrdILista(ordLista);
                ordLista.Save();


            }
        }

        public static void läggTillOrdILista(WordList words)
        {
            string[]? ord = new string[words.Languages.Length];
            bool läggTillFler = true;
            int index = 0;
            string temp = string.Empty;
            do
            {
                foreach (var language in words.Languages)
                {
                    System.Console.WriteLine($"Skriv in ett ord på {language}: ");
                    temp = System.Console.ReadLine();
                    
                    if (String.IsNullOrWhiteSpace(temp))
                    {
                        läggTillFler = false;
                        break;
                    }
                    ord[index] = temp;
                    index++;

                }

                if (läggTillFler)
                {
                    words.Add(ord);
                }

                index = 0;
            } while (läggTillFler);
        }

        public static void ListaListor()
        {
            string[] listor = WordList.GetLists();
            foreach (string lista in listor)
            {
                System.Console.WriteLine(lista);

            }
        }
        public static void SkapaLista(string name, params string[] languages)
        {
            string fullSökVäg = WordList.sökväg + $"\\{name}.dat";
            if (!File.Exists(fullSökVäg))
            {
                var newList = new WordList(name, languages);


                System.Console.WriteLine(fullSökVäg);
                using (FileStream fileStream = File.Create(fullSökVäg))
                { }
                using (StreamWriter sr = new StreamWriter(fullSökVäg))
                {
                    foreach (string language in languages)
                    {
                        System.Console.WriteLine(language);
                        sr.Write($"{language};");

                    }
                    newList.Add(languages);

                }

                System.Console.WriteLine("sökväg finns inte, skapar...");

                //Directory.CreateDirectory(WordList.sökväg);
            }
            else
            {
                System.Console.WriteLine("Listan finns redan");
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