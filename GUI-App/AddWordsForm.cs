using WordsLibrary;

namespace GUI_App
{
    public partial class AddWordsForm : Form
    {
        private List<string> wordsToAdd = new List<string>();
        private WordList currentList;
        private int numberOfLanguages;
        string[] words;
        string currentWord;
        bool hasSpecialChar = false;
        private Label[] labels;
        private TextBox[] textboxes;
        public AddWordsForm(WordList list)
        {
            currentList = list;
            numberOfLanguages = currentList.Languages.Length;
            InitializeComponent();

            this.Text = "Adding words to: " + currentList.Name;
            GenerateLanguageInput();

            words = new string[currentList.Languages.Length];
        }
        private void addWordsButton_Click(object sender, EventArgs e)
        {
            foreach (var textbox in textboxes)
            {
                if (textbox.Text.Any(ch => !Char.IsLetter(ch)))
                {
                    hasSpecialChar = true;
                }
                if (textbox.Text.Any(ch => Char.IsWhiteSpace(ch)))
                {
                    hasSpecialChar = false;
                }
                currentWord += textbox.Text + ";";
            }
            if (!hasSpecialChar)
            {
                wordsToAdd.Add(currentWord);
                addedWordsListBox.DataSource = wordsToAdd.ToArray();
                currentWord = string.Empty;
                foreach (var textbox in textboxes)
                {
                    textbox.Text = string.Empty;
                }
            }
            else
                MessageBox.Show("Words cannot have special characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                currentWord = string.Empty;
        }
        private void removeWordButton_Click(object sender, EventArgs e)
        {
            wordsToAdd.RemoveAt(addedWordsListBox.SelectedIndex);
            addedWordsListBox.DataSource = wordsToAdd.ToArray();
        }

        private void saveListButton_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show($"Are you sure you want add these words to the list: {currentList.Name}? This will save the words to the file", "Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (d.Equals(DialogResult.Yes))
            {
                foreach (var word in wordsToAdd)
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        words = word.Split(";");
                        words = words.SkipLast(1).ToArray();
                    }
                    currentList.Add(word);
                }
                currentList.Save();
                this.Close();
            }
        }
        private void GenerateLanguageInput()
        {
            labels = new Label[currentList.Languages.Length];
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i] = new Label();
                labels[i].Size = new Size(100, 25);
                labels[i].Location = new Point(25, 50 * i + 20);
                labels[i].Text = $"{currentList.Languages[i]}: ";
                panel1.Controls.Add(labels[i]);
            }
            textboxes = new TextBox[currentList.Languages.Length];
            for (int i = 0; i < textboxes.Length; i++)
            {
                textboxes[i] = new TextBox();
                textboxes[i].Size = new Size(157, 31);
                textboxes[i].Location = new Point(139, 50 * i + 20);
                if (i == textboxes.Length-1)
                {
                textboxes[i].KeyDown += AddWordsForm_KeyDown;
                }

                panel1.Controls.Add(textboxes[i]);
            }
        }

        private void AddWordsForm_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addWordsButton_Click(this, new EventArgs());
            }
        }
    }
}
