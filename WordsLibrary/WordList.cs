namespace WordsLibrary
{
    public class WordList
    {
        public string? Name { get; }
        public string[]? Languages { get; }

        private List<Word> listWithWords = new();

        private const string separator = ";";
        private static string[]? languageRow;
        public static readonly string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Labb3");


        public WordList(string name, params string[] languages)
        {
            // Konstruktor. Sätter properites Name och Languages till parametrarnas värden.
            this.Name = name;
            this.Languages = languages;

        }
        public static string[] GetLists()
        {
            // Returnerar array med namn på alla listor som finns lagrade (utan filändelsen).
            string[] files = Directory.GetFiles(folderPath, "*.dat");
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

            string[] words = File.ReadAllLines(Path.Combine(folderPath, name + ".dat"));
            string[] currentRow = new string[words.Length];

            languageRow = words[0].Split(separator);
            languageRow = languageRow.SkipLast(1).ToArray();

            var myWordList = new WordList(name, languageRow);
            for (int i = 1; i < words.Length; i++)
            {
                currentRow = words[i].Split(separator);
                currentRow = currentRow.SkipLast(1).ToArray();
                myWordList.Add(currentRow);
            }

            return myWordList;
        }
        public void Save()
        {
            // Sparar listan till en fil med samma namn som listan och filändelse .dat 
            if (Directory.Exists(folderPath))
            {
                string helaSökvägenTillFilen;
                Console.WriteLine($"Sparar filen: {this.Name}...");
                helaSökvägenTillFilen = Path.Combine(folderPath, this.Name + ".dat");

                using (StreamWriter writeToFile = new StreamWriter(helaSökvägenTillFilen))
                {
                    foreach (var language in this.Languages)
                    {
                        writeToFile.Write(language + separator);
                    }
                    for (int i = 1; i < listWithWords.Count; i++)
                    {
                        writeToFile.WriteLine();
                        foreach (var ord in listWithWords[i].Translations)
                        {
                            if (ord.Last().Equals(';'))
                            {
                                writeToFile.Write(ord);
                            }
                            else
                            {
                                writeToFile.Write(ord + separator);
                            }

                        }

                    }

                }

            }

        }
        public void Add(params string[] translations)
        {
            string[] tempString = new string[translations.Length];

            // Har man inte med detta så tar programmet endast det sista värdet man skrev. Ingen aning varför för den borde lägga in en likadan array.
            for (int i = 0; i < tempString.Length; i++)
            {
                tempString[i] = translations[i];
            }

            listWithWords.Add(new Word(tempString));
        }

        public bool Remove(int translation, string word)
        {
            // translation motsvarar index i Languages. Sök igenom språket och ta bort ordet.
            // Returnerar true om ordet fanns(och alltså tagits bort), annars false.

            //Spelar det någon roll vilket språk man anger ifall man ändå bra skall ta bort hela ordet? Alltså båda översättningarna?

            return true;
        }

        public int Count()
        {
            // Räknar och returnerar antal ord i listan. 
            Console.WriteLine($"Name är: {this.Name}");
            string nysökväg = Path.Combine(folderPath, Name + ".dat");

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

            //Förstår inte riktigt hur man skall använda action här. 
            // Man bör använda sig utav LinQ här?


        }

        public Word GetWordToPractice()
        {
            // Returnerar slumpmässigt Word från listan
            // skall ha slumpmässigt valda FromLanguage och ToLanguage(dock inte samma).
            // Är FromLanguage == 0 så skall man äversätta från språket på första platsen i listan. ToLanguage är sedan språket man skall översätta till. 

            Random randomLanguage = new Random();

            // fortfarande osäker på hur man skall använda From/ToLanguage då dem är read only. När skall man sätta värdet om inte i add() där man anropar konstruktorn? 
            Console.WriteLine("GetWordToPractice skriver ut: " + this.listWithWords[2].Translations[0]);


            

            return new Word();
        }


    }
}
