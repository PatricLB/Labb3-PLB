using WordsLibrary;

namespace GUI_App
{
    public partial class PracticeWordForm : Form
    {

        private StartupForm startForm;
        int correctAnswers = default;
        int timesPracticed = default;
        float totalSum = default;

        string userInput;
        Word wordToTrain;
        int fromLanguage;
        int toLanguage;
        WordList currentList;

        // Behöver fields för listans namn så att jag kan använda den infon för att hämta ett random word från wordlist! 
        public PracticeWordForm(WordList trainingList)
        {
            currentList = trainingList;

            InitializeComponent();

            GenerateExcercise(currentList);

        }

        private void submitAnswerButton_Click(object sender, EventArgs e)
        {
            userInput = userAnswerTextBox.Text.ToLower();

            if (userInput.Equals(wordToTrain.Translations[toLanguage].ToLower()))
            {
                MessageBox.Show($"Your answer was correct!", "Correct!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                correctAnswers++;
                timesPracticed++;
            }
            else
            {
                MessageBox.Show($"Your answer was incorrect!", "Wrong!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                timesPracticed++;
            }
            GenerateExcercise(currentList);

        }

        private void GenerateExcercise(WordList trainingList)
        {
            wordToTrain = trainingList.GetWordToPractice();
            fromLanguage = wordToTrain.FromLanguage.Value;
            toLanguage = wordToTrain.ToLanguage.Value;

            randomWordTextBox.Text = (string)wordToTrain.Translations[fromLanguage];
            labelFromLang.Text = String.Format($"From: {trainingList.Languages[fromLanguage]}");
            labelToLang.Text = String.Format($"To: {trainingList.Languages[toLanguage]}");

            userInput = String.Empty;
            userAnswerTextBox.Text = String.Empty;
        }

        private void PracticeWordForm_FormClosing(Object sender, FormClosingEventArgs e)
        {
            float totalSum = ((float)correctAnswers / timesPracticed) * 100;
            e.Cancel = true;

            DialogResult d;
            d = MessageBox.Show($"Do you want to stop the practice?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (d.Equals(DialogResult.Yes))
            {
                MessageBox.Show($"Good job! You got {Math.Round(totalSum)}% of the words correctly. \nYou practiced {timesPracticed} words.", "End of Training", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = false;
            }
        }
    }
}
