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

            words = new string[currentList.Languages.Length];
        }

        private void addWordsButton_Click(object sender, EventArgs e)
        {
            hasSpecialChar = false;
            if (numberOfLanguages == 2 && (languageTextBox1.Text.Equals(String.Empty) || languageTextBox2.Text.Equals(String.Empty)))
            {
                MessageBox.Show("Textboxes cannot be empty", "Empty");
            }
            else if (numberOfLanguages == 3 && (languageTextBox1.Text.Equals(String.Empty) || languageTextBox2.Text.Equals(String.Empty) || languageTextBox3.Text.Equals(String.Empty)))
            {
                MessageBox.Show("Textboxes cannot be empty", "Empty");
            }
            else if (numberOfLanguages == 4 && (languageTextBox1.Text.Equals(String.Empty) || languageTextBox2.Text.Equals(String.Empty) || languageTextBox3.Text.Equals(String.Empty) || languageTextBox4.Text.Equals(String.Empty)))
            {
                MessageBox.Show("Textboxes cannot be empty", "Empty");
            }
            else
            {
                words[0] = languageTextBox1.Text;
                words[1] = languageTextBox2.Text;



                if (numberOfLanguages == 3)
                {

                    words[2] = languageTextBox3.Text;
                }
                else if (numberOfLanguages == 4)
                {
                    words[2] = languageTextBox3.Text;
                    words[3] = languageTextBox4.Text;
                }

                for (int i = 0; i < numberOfLanguages; i++)
                {
                    foreach (var word in words)
                    {
                        if(word.Any(ch => !Char.IsLetter(ch)))
                        {
                            hasSpecialChar = true;
                            
                        }
                    }
                    tempWords += words[i] + ";";
                }

                if (!hasSpecialChar)
                {
                    wordsToAdd.Add(tempWords);
                    tempWords = string.Empty;

                    languageTextBox1.Text = String.Empty;
                    languageTextBox2.Text = String.Empty;
                    languageTextBox3.Text = String.Empty;
                    languageTextBox4.Text = String.Empty;

                    addedWordsListBox.DataSource = wordsToAdd.ToArray();
                }
                else
                    MessageBox.Show("Words cannot have special characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tempWords = string.Empty;

            }
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
    }
}
