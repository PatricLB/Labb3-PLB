namespace WordsLibrary
{
    public class Word
    {
        public string[]? Translations { get; }
        public int? FromLanguage { get; }
        public int? ToLanguage { get; }

        public Word(params string[] translations)
        {
            this.Translations = translations;
            Console.WriteLine("Från konstruktorn: " + this.Translations[0]);
        }

        public Word(int fromLanguage, int toLanguage, params string[] translations)
        {
            this.Translations = translations;
            this.ToLanguage   = toLanguage;
            this.FromLanguage = fromLanguage;
        }

    }
}