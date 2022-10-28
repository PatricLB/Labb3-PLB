using WordsLibrary;

namespace GUI_App
{
    public partial class NewListForm : Form
    {

        private List<string> languages = new List<string>();
        WordList? newlyCreatedlist;

        public NewListForm()
        {
            InitializeComponent();
        }

        private void addLanguageButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(userInputLanguageBox.Text))
            {
                languages.Add(userInputLanguageBox.Text);
                languagesToBeAddedBox.DataSource = languages.ToArray();
                userInputLanguageBox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Please enter a language", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }


        }

        private void removeLanguageButton_Click(object sender, EventArgs e)
        {
            string? currentItem = languagesToBeAddedBox.SelectedItem?.ToString();
            if (languages.Contains(currentItem))
            {
                languages.Remove(currentItem);
                languagesToBeAddedBox.DataSource = languages.ToArray();
            }
            else
                MessageBox.Show("Language does not exist in list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void addWordsButton_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show($"Are you sure you want to continue with the list creation? File will be saved", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (d.Equals(DialogResult.Yes))
                try
                {
                    newlyCreatedlist = CreateFileInDir();
                    AddWordsForm addWords = new AddWordsForm(newlyCreatedlist);
                    addWords.ShowDialog();
                    this.Close();

                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Only 2 to 4 languages are supported. If you want more please use the Console App", "Incorrect amount of languages", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (IOException)
                {
                    MessageBox.Show($"Cannot save file. It already exists", "File already Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show($"Files does not have a valid filename. Please enter a name for the file.", "File error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

        }
        private WordList CreateFileInDir()
        {
            string fileName = GetNewFileName();
            string fullSökVäg = Path.Combine(WordList.folderPath, fileName + ".dat");
            List<String> language = GetNewLanguages();

            if (string.IsNullOrEmpty(fileName) || fileName.Any(ch => Char.IsWhiteSpace(ch)))
                throw new Exception("Files are not allowed to have white spaces or be empty");

            if (language.Count < 2)
                throw new Exception("Not enough languages. There needs to be atleast two languages in the list.");

            if (!File.Exists(fullSökVäg))
                throw new Exception("File already exists");

            var newList = new WordList(fileName, language.ToArray());
            using (StreamWriter sr = new StreamWriter(fullSökVäg))
            {
                foreach (string lang in language)
                {
                    sr.Write($"{lang};");
                }
            }

            return newList;
        }


        private void NewListForm_FormClosing(Object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            DialogResult d;
            d = MessageBox.Show($"Changes has not been saved. Do you want to cancel?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (d.Equals(DialogResult.Yes))
            {
                e.Cancel = false;
            }
        }

        public string GetNewFileName()
        {
            return nameOfFileBox.Text;
        }

        public List<string> GetNewLanguages()
        {
            return languages;
        }
    }
}
