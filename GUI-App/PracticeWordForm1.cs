using WordsLibrary;

namespace GUI_App
{
    public partial class PracticeWordForm : Form
    {
        int correctAnswers = default;
        int timesPracticed = 0;
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
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

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
            labelFromLang.Text = $"From: {trainingList.Languages[fromLanguage]}";
            labelToLang.Text = $"To: {trainingList.Languages[toLanguage]}";

            userInput = String.Empty;
            userAnswerTextBox.Text = String.Empty;
        }

        private void PracticeWordForm_FormClosing(Object sender, FormClosingEventArgs e)
        {
            totalSum = ((float)correctAnswers / timesPracticed) * 100;
            e.Cancel = true;

            DialogResult d;
            d = MessageBox.Show($"Do you want to stop the practice?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (d.Equals(DialogResult.Yes))
            {
                if(timesPracticed == 0)
                {
                    e.Cancel = false;
                }
                else
                MessageBox.Show($"Good job! You got {Math.Round(totalSum)}% of the words correctly. \nYou practiced {timesPracticed} words.", "End of Training", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = false;
            }
        }

        private void userAnswerTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                submitAnswerButton_Click(this, new EventArgs());
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
