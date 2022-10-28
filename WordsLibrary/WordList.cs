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
            string[] words = File.ReadAllLines(Path.Combine(folderPath, name + ".dat"));
            string[] currentRow = new string[words.Length];

            languageRow = words[0].ToLower().Split(separator);
            if (string.IsNullOrEmpty(languageRow[0]))
                throw new Exception("Top row in file cannot be empty");


            languageRow = languageRow.SkipLast(1).ToArray();
            foreach (var language in languageRow)
            {
                if (String.IsNullOrEmpty(language))
                    throw new Exception("Languages cannot be empty");
            }


            var myWordList = new WordList(name, languageRow);
            for (int i = 1; i < words.Length; i++)
            {
                currentRow = words[i].Split(separator);
                currentRow = currentRow.SkipLast(1).ToArray();
                myWordList.Add(currentRow);
            }

            // Kolla ifall alla rader är korrekta med en loop

            return myWordList;
        }
        public void Save()
        {
            if (Directory.Exists(folderPath))
            {
                string helaSökvägenTillFilen;
                helaSökvägenTillFilen = Path.Combine(folderPath, Name + ".dat");

                using (StreamWriter writeToFile = new StreamWriter(helaSökvägenTillFilen))
                {
                    foreach (var language in Languages)
                    {
                        writeToFile.Write(language.ToLower() + separator);
                    }
                    writeToFile.WriteLine();
                    for (int i = 0; i < listWithWords.Count; i++)
                    {
                        foreach (var word in listWithWords[i].Translations)
                        {
                            if (word.Last().Equals(';'))
                            {
                                writeToFile.Write(word);
                            }
                            else
                            {
                                writeToFile.Write(word + separator);
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
            var randomWord = listWithWords[Random.Shared.Next(listWithWords.Count)];
            var returnWord = new Word(fromLanguage, toLanguage, randomWord.Translations);

            return returnWord;
        }

    }
}
