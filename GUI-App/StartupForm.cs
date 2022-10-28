using WordsLibrary;

namespace GUI_App
{
    public partial class StartupForm : Form
    {
        private static string newLine = Environment.NewLine;
        private static string? _currentItem = string.Empty;
        string[]? listOfAvailableLists;
        List<string> noValueList = new List<string>();
        bool isListOK = true;
        public static string? CurrentItem
        {
            get
            {
                return _currentItem;
            }
            set
            {
                _currentItem = value;

            }
        }
        private static string? textBoxInfo;
        private static int? wordCount = default;
        private static WordList? list;

        public StartupForm()
        {
            if (!Directory.Exists(WordList.folderPath))
                Directory.CreateDirectory(WordList.folderPath);

            InitializeComponent();

        }

        private void StartupForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAvailableLists();
                list = WordList.LoadList(listOfAvailableLists[0].ToString());
                UpdateTextBox(list);
                languageSortBox.DataSource = list.Languages;
                noValueList.Add("N/A");

                wordCount = list.Count();
                countLabel.Text = String.Format($"Antal ord: {wordCount}");
                listContentTextBox.SelectionStart = 0;

            }
            catch (Exception)
            {

            }

        }

        private void LoadAvailableLists()
        {
            listOfAvailableLists = WordList.GetLists();
            wordListBox.DataSource = listOfAvailableLists;

        }

        private void WordListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listContentTextBox.Text = string.Empty;
            CurrentItem = wordListBox.SelectedItem.ToString();
            try
            {
                list = WordList.LoadList(CurrentItem);
                UpdateTextBox(list);

                languageSortBox.DataSource = list.Languages;
                countLabel.Text = $"Antal ord: {list.Count()}";
                isListOK = true;
            }
            catch (Exception ex)
            {
                languageSortBox.DataSource = noValueList;
                listContentTextBox.Text = $"List could not be loaded. Error: {ex.Message}";
                countLabel.Text = "Antal ord: N/A";
                isListOK = false;

            }
        }

        private void languageSortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listContentTextBox.Text = string.Empty;
            CurrentItem = wordListBox.SelectedItem.ToString();
            int value = languageSortBox.SelectedIndex;

            UpdateTextBox(list, value);

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Are you sure you want to exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (d.Equals(DialogResult.Yes))
            {
                Environment.Exit(0);
            }

        }
        private void TrainWordsButton_Click(object sender, EventArgs e)
        {
            if (!isListOK)
            {
                MessageBox.Show($"List cannot be loaded. Choose a different list.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult d;
                d = MessageBox.Show($"Do you want to practice words from {CurrentItem} ?", "Practice?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (d.Equals(DialogResult.Yes))
                {
                    try
                    {
                    PracticeWordForm practiceWord = new PracticeWordForm(list);
                    this.Hide();
                    practiceWord.ShowDialog();
                    this.Show();

                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show($"Cannot load practice. {exc.Message}", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
        }

        private void addWordsButton_Click(object sender, EventArgs e)
        {
            try
            {
                AddWordsForm addWords = new AddWordsForm(list);
                addWords.ShowDialog();
                UpdateTextBox(list);
            }
            catch (ObjectDisposedException)
            {
                MessageBox.Show("More languages than 5 is not supported in the GUI app.", "To many languages");
            }
        }

        private void removeWordsButton_Click(object sender, EventArgs e)
        {
            RemoveWordsForm newList = new RemoveWordsForm(list);
            newList.ShowDialog();
            getTextBoxInfo();
            UpdateTextBox(list);
        }

        private void openToolStripNewList_Click(object sender, EventArgs e)
        {
            NewListForm newList = new NewListForm();
            newList.ShowDialog();
            LoadAvailableLists();
        }

        public void UpdateTextBox(WordList words, int sort = 0)
        {
            try
            {
                listContentTextBox.Text = String.Empty;
                List<string> fullText = new List<string>();

                words.List(sort, s => { fullText.Add(String.Join(";", s)); });
                foreach (var word in fullText)
                {
                    listContentTextBox.Text += word + newLine;
                }

            }
            catch (NullReferenceException ex)
            {
                throw ex;
            }

        }
        public void getTextBoxInfo()
        {
            textBoxInfo = listContentTextBox.Text;

        }
        public static string GetListName()
        {
            return CurrentItem;
        }
    }
}