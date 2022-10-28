using WordsLibrary;

namespace GUI_App
{
    public partial class StartupForm : Form
    {
        public static string newLine = Environment.NewLine;
        private static string _currentItem = string.Empty;
        string[] listOfAvailableLists;
        public static string CurrentItem
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
        public static string textBoxInfo = string.Empty;
        public static int wordCount = default;
        public static WordList list;

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

        private void wordListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listContentTextBox.Text = string.Empty;
            CurrentItem = wordListBox.SelectedItem.ToString();
            try
            {
                list = WordList.LoadList(CurrentItem);
                UpdateTextBox(list);

                languageSortBox.DataSource = list.Languages;
                countLabel.Text = $"Antal ord: {list.Count()}";
            }
            catch (Exception ex)
            {

                listContentTextBox.Text = $"List could not be loaded. Error: {ex.Message}";
                languageSortBox.Text = "N/A";
                countLabel.Text = "Antal ord: N/A";

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
        private void trainWordsButton_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show($"Do you want to practice words from {CurrentItem} ?", "Practice?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (d.Equals(DialogResult.Yes))
            {
                PracticeWordForm practiceWord = new PracticeWordForm(list);
                this.Hide();
                practiceWord.ShowDialog();
                this.Show();

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
            catch (Exception ObjectDisposedException)
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