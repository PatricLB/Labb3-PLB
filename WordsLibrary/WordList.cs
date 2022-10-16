namespace WordsLibrary
{
    public class WordList
    {
        public string? Name { get; }
        public string[]? Languages { get; }

        private List<Word> listaMedOrd = new();

        private const string Separator = ";";
        private static string[]? förstaRaden;
        private static readonly string sökväg = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Labb3";


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
                lists[i] = files[i].Remove(0, sökväg.Length + 1);
                lists[i] = lists[i].Replace(".dat", "");
            }

            return lists;
        }

        public static WordList LoadList(string name)
        {
            // Laddar in ordlistan (name anges utan filändelse) och returnerar som WordList. 

            try
            {
                using (StreamReader sr = new StreamReader(sökväg + "\\" + name + ".dat"))
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

            if (!Directory.Exists(sökväg))
            {
                Console.WriteLine("sökväg finns inte, skapar...");
                Directory.CreateDirectory(sökväg);
            }
            string helaSökvägenTillFilen;
            Console.WriteLine($"Name är: {this.Name}");
            helaSökvägenTillFilen = sökväg + "\\" + Name + ".dat";


            //Oklart hur jag skall göra denna
            using (StreamWriter skrivTillFil = File.AppendText(helaSökvägenTillFilen))
            {
                skrivTillFil.WriteLine(listaMedOrd[0] + ";" + listaMedOrd[1]);
            }


        }

        public void Add(params string[] translations)
        {
            // Lägger till ord i listan. Kasta ArgumentException om det är fel antal translations. 
            string[]? ord = new string[2];
            bool läggTillFler = true;
            // ListaMedOrd är inte helt korrekt. Den är nu words men den skriver över hela tiden. Osäker på hur man skall lägga till dem i listan.
            do
            {
                Console.WriteLine($"Skriv in ett ord på {translations[0]}: ");
                ord[0] = Console.ReadLine();
                if (ord[0] == "" || ord[0] == " ")
                {
                    läggTillFler = false;
                    break;
                }
                Console.WriteLine($"Skriv in ett ord på {translations[1]}: ");
                ord[1] = Console.ReadLine();
                Console.WriteLine("ord1: " + ord[0] + " ord2: " + ord[1]);

                // Av någon anledning så skriver nedan funktion över alla nästkommande ord. Tex skriver man "hej", "hi" och sen "skola","School" så finns inte "Hej","hi" kvar. Kolla upp detta.
                listaMedOrd.Add(new Word(ord));

                if (ord[1] == "" || ord[1] == " ")
                {
                    läggTillFler = false;
                    break;
                }


            } while (läggTillFler);

            for (int i = 0; i < listaMedOrd.Count; i++)
            {
                Console.WriteLine(listaMedOrd[i].Translations[i]);
            }

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
            string nysökväg = sökväg + "\\" + Name + ".dat";

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
