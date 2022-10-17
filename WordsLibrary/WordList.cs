using System.Xml.Linq;

namespace WordsLibrary
{
    public class WordList
    {
        public string? Name { get; }
        public string[]? Languages { get; }

        private List<Word> listaMedOrd = new();

        private const string Separator = ";";
        private static string[]? förstaRaden;
        public static readonly string sökväg = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Labb3");


        public WordList(string name, params string[] languages)
        {
            // Konstruktor. Sätter properites Name och Languages till parametrarnas värden.
            this.Name = name;
            this.Languages = languages;

        }

        public static string[] GetLists()
        {
            // Returnerar array med namn på alla listor som finns lagrade (utan filändelsen).
            string[] files = Directory.GetFiles(sökväg, "*.dat");
            string[] lists = new string[files.Length];
            for (int i = 0; i < files.Length; i++)
            {
                lists[i] = Path.GetFileNameWithoutExtension(files[i]);
            }

            return lists;
        }

        public static WordList LoadList(string name)
        {
            // Laddar in ordlistan (name anges utan filändelse) och returnerar som WordList. 

            try
            {
                using (StreamReader sr = new StreamReader(Path.Combine(sökväg, name + ".dat")))
                {
                    förstaRaden = sr.ReadLine()?.Split(Separator);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            return new WordList(name, förstaRaden);
        }

        public void Save()
        {
            // Sparar listan till en fil med samma namn som listan och filändelse .dat 

            if (Directory.Exists(sökväg))
            {
                string helaSökvägenTillFilen;
                Console.WriteLine($"Name är: {this.Name}");
                helaSökvägenTillFilen = Path.Combine(sökväg, this.Name + ".dat");

                using (StreamWriter skrivTillFil = File.AppendText(helaSökvägenTillFilen))
                {
                    skrivTillFil.WriteLine();
                    for (int i = 0; i < listaMedOrd.Count; i++)
                    {
                        foreach (var ord in listaMedOrd[i].Translations)
                        {
                            skrivTillFil.Write(i == 0 ? ord + Separator : Separator + ord + Separator);
                        }
                       skrivTillFil.WriteLine();
                       
                    }
                }
            }


        }

        public void Add(params string[] translations)
        {

            listaMedOrd.Add(new Word(translations));

        }

        public bool Remove(int translation, string word)
        {
            // translation motsvarar index i Languages. Sök igenom språket och ta bort ordet.
            // Returnerar true om ordet fanns(och alltså tagits bort), annars false.

            return true;
        }

        public int Count()
        {
            // Räknar och returnerar antal ord i listan. 
            Console.WriteLine($"Name är: {this.Name}");
            string nysökväg = Path.Combine(sökväg, Name + ".dat");

            Console.WriteLine(nysökväg);
            int antalOrd = 0;
            try
            {
                using (StreamReader sr = new StreamReader(nysökväg))
                {
                    string? line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        antalOrd++;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }


            return antalOrd - 1;
        }

        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
            // sortByTranslation = Vilket språk listan ska sorteras på.
            // showTranslations = Callback som anropas för varje ord i listan.



        }

        public Word GetWordToPractice()
        {
            // Returnerar slumpmässigt Word från listan, med slumpmässigt valda
            // FromLanguage och ToLanguage(dock inte samma).
            return new Word();
        }


    }
}
