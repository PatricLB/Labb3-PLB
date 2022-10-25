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
            try
            {
                string[] words = File.ReadAllLines(Path.Combine(folderPath, name + ".dat"));

                string[] currentRow = new string[words.Length];

                languageRow = words[0].ToLower().Split(separator);
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
            catch (Exception e)
            {
                if (e.GetType().Name == "FileNotFoundException")
                    Console.WriteLine($"List could not be loaded. File was not found.");

                return null;
            }
        }
        public void Save()
        {
            // Sparar listan till en fil med samma namn som listan och filändelse .dat 
            if (Directory.Exists(folderPath))
            {
                string helaSökvägenTillFilen;
                helaSökvägenTillFilen = Path.Combine(folderPath, Name + ".dat");

                using (StreamWriter writeToFile = new StreamWriter(helaSökvägenTillFilen))
                {

                    //Consider using Join here instead
                    // Or use Linq query syntax to get Languages in a string. Then write that string to the file.
                    foreach (var language in Languages)
                    {
                        writeToFile.Write(language.ToLower() + separator);
                    }
                    writeToFile.WriteLine();
                    for (int i = 0; i < listWithWords.Count; i++)
                    {

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
                        writeToFile.WriteLine();
                    }

                }

            }

        }
        public void Add(params string[] translations)
        {
            listWithWords.Add(new Word(translations));
        }

        public bool Remove(int translation, string word)
        {
            // translation motsvarar index i Languages. Sök igenom språket och ta bort ordet.
            // Returnerar true om ordet fanns(och alltså tagits bort), annars false.

            //var whatToRemove = from w in listWithWords
            //                   where w.Translations[translation].Equals(word)
            //                   select w;

            var WhatToRemove = listWithWords.Find(w => w.Translations[translation].Equals(word));

            if (WhatToRemove != null)
            {
                return listWithWords.Remove(WhatToRemove);
            }
            return false;
        }

        public int Count()
        {
            // Räknar och returnerar antal ord i listan. 

            return listWithWords.Count;

        }
        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
            var sortedList = from sl in listWithWords
                             orderby sl.Translations[sortByTranslation]
                             select sl;

            foreach (var ord in sortedList)
            {
                showTranslations.Invoke(ord.Translations);
            }


        }
        public Word GetWordToPractice()
        {
            Random randomLanguage = new Random();
            int fromLanguage = randomLanguage.Next(Languages.Length);
            int toLanguage = randomLanguage.Next(Languages.Length);

            while (fromLanguage == toLanguage)
            {
                fromLanguage++;
                if (fromLanguage >= Languages.Length)
                {
                    fromLanguage = 0;
                }
            }
            var randomOrd = listWithWords[Random.Shared.Next(listWithWords.Count)];
            var ord = new Word(fromLanguage, toLanguage, randomOrd.Translations);

            return ord;
        }

    }
}
