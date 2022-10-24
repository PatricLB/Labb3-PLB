using System.Security.Cryptography;
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
                string name = "tvåSpråk";
                string[] språk = new string[2] { "Engelska", "Svenska" };
                ListaListor();
                System.Console.WriteLine();
                //var ordLista = CreateList("ExempelPåLista6", "Engelska", "Svenska");
                //var listaMedOrd = CreateList("tvåSpråk", "Engelska", "Svenska");
                var trainWordsList = WordList.LoadList("example2");

                //TrainWords(trainWordsList);
                trainWordsList.List(1, s => {System.Console.WriteLine(String.Join("\t | ", s));});
                AddWordToList(trainWordsList);
                trainWordsList.List(0, s => {System.Console.WriteLine(String.Join("\t | ", s)); });
                //AddWordToList(trainWordsList);
                //trainWordsList.Save();

                //if (RemoveWordFromList(ordLista, 1, "säng"))
                //{
                //    System.Console.WriteLine("Tog bort ordet.");
                //    ordLista.Save();
                //}
                //else
                //{
                //    System.Console.WriteLine("Ordet fanns inte.");
                //}
                //listaMedOrd.Save();



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

                System.Console.WriteLine($"Översätt {wordToTrain.Translations[fromLanguage]} " +
                    $"från {name.Languages[fromLanguage]} " +
                    $"till {name.Languages[toLanguage]}");

                userInput = System.Console.ReadLine();
                if (String.IsNullOrWhiteSpace(userInput))
                {
                    continueTraining = false;
                    break;
                }
                if (userInput.ToLower() == wordToTrain.Translations[toLanguage].ToLower())
                {
                    correctAnswers++;
                    System.Console.WriteLine("Rätt svar!");
                }
                else
                {
                    System.Console.WriteLine("Fel svar!");
                }
                
                timesPracticed++;

            } while (continueTraining);
            float totalSum = ((float)correctAnswers / timesPracticed) * 100;

            System.Console.WriteLine($"Du fick {Math.Round(totalSum)}% rätta svar! ");

        }
        public static WordList CreateList(string name, params string[] languages)
        {
            string fullSökVäg = Path.Combine(WordList.folderPath, name + ".dat");
            if (!File.Exists(fullSökVäg))
            {
                var newList = new WordList(name, languages);
                System.Console.WriteLine("Filen finns inte, skapar...");

                System.Console.WriteLine(fullSökVäg);
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
            {
                System.Console.WriteLine("Filen finns redan. Kan inte skapa");
                return null;
            }
        }
        public static void AddWordToList(WordList words)
        {
            if (words.Languages.Length == 0)
            {
                System.Console.WriteLine("Ingen giltligt lista.");
            }
            else
            {
                bool läggTillFler = true;
                int index = 0;
                string input = string.Empty;
                do
                {
                    string[]? ord = new string[words.Languages.Length];

                    foreach (var language in words.Languages)
                    {
                        System.Console.WriteLine($"Skriv in ett ord på {language}: ");
                        input = System.Console.ReadLine();

                        if (String.IsNullOrWhiteSpace(input))
                        {
                            läggTillFler = false;
                            break;
                        }
                        ord[index] = input;
                        index++;

                    }

                    if (läggTillFler)
                    {
                        words.Add(ord);
                    }

                    index = 0;
                } while (läggTillFler);

            }
        }
        public static void ListaListor()
        {
            string[] listor = WordList.GetLists();
            foreach (string lista in listor)
            {
                System.Console.WriteLine(lista);

            }
        }
        public static bool RemoveWordFromList(WordList wordList, int translation, string word)
        {

            return wordList.Remove(translation, word);
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