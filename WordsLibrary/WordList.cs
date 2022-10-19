namespace WordsLibrary
{
    public class WordList
    {
        public string? Name { get; }
        public string[]? Languages { get; }

        private List<Word> listaMedOrd = new();

        private const string Separator = ";";
        private static string[]? firstRow;
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

            string[] words = File.ReadAllLines(Path.Combine(sökväg, name + ".dat"));
            //using (StreamReader sr = new StreamReader(Path.Combine(sökväg, name + ".dat")))
            //{
            //    förstaRaden = sr.ReadLine()?.Split(Separator);
            //}
            firstRow = words[0].Split(Separator);
            string[] firstRowFixed = firstRow.SkipLast(1).ToArray();

            var myWordList = new WordList(name, firstRowFixed);
            for (int i = 1; i < words.Length; i++)
            {
                myWordList.Add(words[i]);
            }

            return myWordList;
        }

        public void Save()
        {
            // Sparar listan till en fil med samma namn som listan och filändelse .dat 
            if (Directory.Exists(sökväg))
            {
                string helaSökvägenTillFilen;
                Console.WriteLine($"Sparar filen: {this.Name}...");
                helaSökvägenTillFilen = Path.Combine(sökväg, this.Name + ".dat");



                // Fungerar bra ifall man skriver till ne ny fil.
                // Problem uppstår när man laddat in en fil. Då appendar man listan, alltså skriver till i botten så att man får dubbla värden. Det uppkommer också ett extra ";" i slutet.

                // Tankar: Gör en check ifall filen är laddad i objektet eller inte med en bool i denna classen? 
                // Skriv över hela filen istället med innehållet i List<Word>?

                //using (StreamWriter skrivTillFil = File.AppendText(helaSökvägenTillFilen))
                //{
                //    skrivTillFil.NewLine = "\n";
                //    for (int i = 0; i < listaMedOrd.Count; i++)
                //    {
                //        skrivTillFil.WriteLine();
                //        foreach (var ord in listaMedOrd[i].Translations)
                //        {
                //            skrivTillFil.Write(ord + Separator);
                //        }
                //    }
                //}
                using (StreamWriter writeToFile = new StreamWriter(helaSökvägenTillFilen))
                {
                    foreach (var language in this.Languages)
                    {
                        writeToFile.Write(language + Separator);
                    }
                    for (int i = 0; i < listaMedOrd.Count; i++)
                    {
                        writeToFile.WriteLine();
                        foreach (var ord in listaMedOrd[i].Translations)
                        {
                            if (ord.Last().Equals(';'))
                            {
                                writeToFile.Write(ord);
                            }
                            else
                            {
                                writeToFile.Write(ord + Separator);
                            }
                            
                        }
                    }
                }
            }
        }

        public void Add(params string[] translations)
        {
            string[] tempString = new string[translations.Length];
            for (int i = 0; i < tempString.Length; i++)
            {
                tempString[i] = translations[i];
            }

            listaMedOrd.Add(new Word(tempString));

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
