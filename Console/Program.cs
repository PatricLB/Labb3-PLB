using WordsLibrary;

namespace Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (!Directory.Exists(WordList.folderPath))
                Directory.CreateDirectory(WordList.folderPath);

            string nameOfList = String.Empty;

            if (args.Length == 0)
                IncorrectParameters();
            else if (args.Length == 1)
                nameOfList = String.Empty;
            else
                nameOfList = args[1];

            switch (args[0].ToLower())
            {
                case "-lists":
                    if (args.Length < 2)
                        PrintAllLists();
                    else
                        IncorrectParameters();
                    break;

                case "-new":
                    try
                    {
                        List<string> lang = new List<string>();
                        for (int i = 2; i < args.Length; i++)
                        {
                            lang.Add(args[i]);
                        }

                        CreateList(nameOfList, lang.ToArray());

                    }
                    catch (Exception e)
                    {
                        System.Console.WriteLine($"Problem creating file. {e.Message}");
                    }
                    break;

                case "-add":
                    if (args.Length == 2)
                        try
                        {
                            var listToAddWordsTo = WordList.LoadList(nameOfList);
                            AddWordToList(listToAddWordsTo);

                        }
                        catch (Exception e)
                        {
                            System.Console.WriteLine($"Could not add words to list. {e.Message}"); ;
                        }
                    else
                        IncorrectParameters();
                    break;

                case "-remove":
                    try
                    {
                        var listToRemoveWordsFrom = WordList.LoadList(nameOfList.ToLower());
                        string language = args[2].ToLower();

                        int lengthOfWordArray = args.Length - 3;
                        string[] wordsToRemove = new string[lengthOfWordArray];

                        int index = Array.IndexOf(listToRemoveWordsFrom.Languages, language);
                        int wordCount = 0;

                        for (int i = 3; i < args.Length; i++)
                        {
                            wordsToRemove[wordCount] = args[i];
                            wordCount++;
                        }

                        foreach (var word in wordsToRemove)
                        {
                            if (RemoveWordFromList(listToRemoveWordsFrom, index, word))
                            {
                                listToRemoveWordsFrom.Save();
                                System.Console.WriteLine($"Removed the word {word} and saved the list.");
                            }
                            else
                            {
                                System.Console.WriteLine("Word did not exist in list or in the specified language.");
                            }
                        }
                    }
                    catch (Exception NullReferenceException) { }
                    break;

                case "-words":
                    var wordsToSort = WordList.LoadList(nameOfList);
                    if (args.Length == 3)
                    {
                        if (wordsToSort.Languages.Contains(args[2].ToLower()))
                        {
                            int index = Array.IndexOf(wordsToSort.Languages, args[2].ToLower());

                            wordsToSort.List(index, s => { System.Console.WriteLine(String.Join("\t | ", s)); });
                        }
                        else
                            System.Console.WriteLine("Language does not exist. Try again.");
                    }
                    else if (args.Length < 3)
                    {
                        wordsToSort.List(0, s => { System.Console.WriteLine(String.Join("\t | ", s)); });
                    }
                    else
                        IncorrectParameters();
                    break;

                case "-count":
                    try
                    {
                        if (args.Length == 2)
                        {
                            var listToCount = WordList.LoadList(nameOfList);
                            System.Console.WriteLine(CountWordsInList(listToCount));
                        }
                        else
                            IncorrectParameters();
                    }
                    catch (Exception) { }
                    break;

                case "-practice":
                    if (args.Length == 2)
                    {
                        try
                        {
                            var listToTrain = WordList.LoadList(nameOfList);
                            TrainWords(listToTrain);

                        }
                        catch (Exception e)
                        {
                            System.Console.WriteLine($"Error: {e.Message}");
                        }
                    }
                    else
                        IncorrectParameters();
                    break;

                default:
                    IncorrectParameters();
                    break;
            }
        }
        public static void TrainWords(WordList name)
        {
            int correctAnswers = 0;
            int timesPracticed = 0;
            bool continueTraining = true;
            string userInput;

            Word wordToTrain;
            int fromLanguage;
            int toLanguage;

            do
            {
                wordToTrain = name.GetWordToPractice();
                fromLanguage = wordToTrain.FromLanguage.Value;
                toLanguage = wordToTrain.ToLanguage.Value;

                System.Console.WriteLine($"Translate {wordToTrain.Translations[fromLanguage]} " +
                    $"from {name.Languages[fromLanguage]} " +
                    $"to {name.Languages[toLanguage]}");

                userInput = System.Console.ReadLine();
                if (String.IsNullOrWhiteSpace(userInput))
                {
                    continueTraining = false;
                    break;
                }
                if (userInput.ToLower() == wordToTrain.Translations[toLanguage].ToLower())
                {
                    correctAnswers++;
                    System.Console.WriteLine("Correct!");
                }
                else
                {
                    System.Console.WriteLine("Wrong answer!");
                }

                timesPracticed++;

            } while (continueTraining);
            float totalSum = ((float)correctAnswers / timesPracticed) * 100;

            System.Console.WriteLine($"You practiced {timesPracticed} words.");
            System.Console.WriteLine($"You got {Math.Round(totalSum)}% of the words answered correctly! ");

        }
        public static WordList CreateList(string name, params string[] languages)
        {
            string fullSökVäg = Path.Combine(WordList.folderPath, name + ".dat");
            if (!File.Exists(fullSökVäg))
            {
                if (languages.Length < 2)
                    throw new ArgumentOutOfRangeException("Not enough languages. There needs to be atleast two languages in the list.");

                var newList = new WordList(name, languages);
                System.Console.WriteLine($"Creating list {name}...");

                using (StreamWriter sr = new StreamWriter(fullSökVäg))
                {
                    foreach (string language in languages)
                    {
                        sr.Write($"{language};");
                    }
                }


                AddWordToList(newList);
                newList.Save();

                return newList;
            }
            else
                throw new Exception("File already exists");
        }
        public static void AddWordToList(WordList words)
        {
            if (words.Languages.Length < 2)
            {
                throw new ArgumentOutOfRangeException("Not enough languages. There needs to be atleast two languages in the list.");
            }
            else
            {
                bool addMore = true;
                int index = 0;
                string input = string.Empty;
                do
                {
                    string[]? ord = new string[words.Languages.Length];

                    foreach (var language in words.Languages)
                    {
                        System.Console.Write($"Write a word in the language {language}: ");
                        input = System.Console.ReadLine();
                        if (String.IsNullOrWhiteSpace(input))
                        {
                            addMore = false;
                            break;
                        }
                        while (input.Any(ch => !Char.IsLetter(ch)) && !input.Contains(" "))
                        {
                            System.Console.WriteLine("Word contains invalid characters. Please try again");
                            System.Console.Write($"Write a word in the language {language}: ");
                            input = System.Console.ReadLine();
                            if (String.IsNullOrWhiteSpace(input))
                            {
                                addMore = false;
                                break;
                            }

                        }
                        if (addMore == false)
                        {
                            break;
                        }

                        ord[index] = input;
                        index++;
                    }
                    if (addMore)
                    {
                        words.Add(ord);
                    }
                    index = 0;
                } while (addMore);
                words.Save();
                System.Console.WriteLine($"Done adding words to list: {words.Name}");
            }
        }
        public static void PrintAllLists()
        {
            string[] listor = WordList.GetLists();
            foreach (string lista in listor)
            {
                System.Console.WriteLine(lista);

            }
        }
        public static bool RemoveWordFromList(WordList wordList, int translation, string word)
        {
            return wordList.Remove(translation, word.ToLower());
        }
        public static string CountWordsInList(WordList wordList)
        {

            int antalOrd = wordList.Count();

            if (antalOrd == 0)
            {
                return "No words in list";
            }
            else
            {
                return $"Amount of words in '{wordList.Name}': {antalOrd}";
            }
        }
        public static void IncorrectParameters()
        {
            string[] choices = new string[7]
                {"-lists",
                "-new <list name> <language 1> <language 2> .. <langauge n>",
                "-add <list name>",
                "-remove <list name> <language> <word 1> <word 2> .. <word n>",
                "-words <listname> <sortByLanguage>",
                "-count <listname>",
                "-practice <listname>"};
            System.Console.WriteLine("Not the correct amount of parameters. Use any of the following: ");
            foreach (string choice in choices)
            {
                System.Console.WriteLine(choice);
            }
            Environment.Exit(0);
        }
    }
}