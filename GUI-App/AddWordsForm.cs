using WordsLibrary;

namespace GUI_App
{
    public partial class AddWordsForm : Form
    {
        private List<string> wordsToAdd = new List<string>();
        private WordList currentList;
        private int numberOfLanguages;
        string[] words;
        string tempWords;
        bool hasSpecialChar = false;
        private Label[] labels;
        private TextBox[] textboxes;
        public AddWordsForm(WordList list)
        {
            currentList = list;
            numberOfLanguages = currentList.Languages.Length;
            InitializeComponent();

            setLanguagesFields(currentList);
            if (currentList.Languages.Length > 4)
            {
                this.Close();
            }
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
                tempWords += textbox.Text + ";";
            }
            if (!hasSpecialChar)
            {
                wordsToAdd.Add(tempWords);
                addedWordsListBox.DataSource = wordsToAdd.ToArray();
                tempWords = string.Empty;
                foreach (var textbox in textboxes)
                {
                    textbox.Text = string.Empty;
                }
            }
            else
                MessageBox.Show("Words cannot have special characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tempWords = string.Empty;
        }
        private void setLanguagesFields(WordList list)
        {
            languageLabel1.Text = currentList.Languages[0].ToString() + ":";
            languageLabel2.Text = currentList.Languages[1].ToString() + ":";
            if (numberOfLanguages > 2)
            {

                languageLabel3.Text = currentList.Languages[2] + ":";

                languageLabel4.Text = "No Language";
                languageTextBox4.Enabled = false;
                languageLabel4.Enabled = false;

                if (numberOfLanguages == 4)
                {
                    languageLabel3.Text = currentList.Languages[2] + ":";
                    languageLabel4.Text = currentList.Languages[3] + ":";
                    languageTextBox4.Enabled = true;
                    languageLabel4.Enabled = true;
                }

            }
            else
            {
                languageLabel3.Text = "No Language";
                languageLabel3.Enabled = false;
                languageTextBox3.Enabled = false;

                languageLabel4.Text = "No Language";
                languageTextBox4.Enabled = false;
                languageLabel4.Enabled = false;
            }
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

        private void languageTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                languageTextBox2.Focus();
            }
        }

        private void languageTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (languageTextBox3.Enabled)
                {
                    languageTextBox3.Focus();
                }
                else
                    addWordsButton.Focus();
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
                panel1.Controls.Add(textboxes[i]);
            }
        }
    }
}
