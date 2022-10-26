using WordsLibrary;

namespace GUI_App
{
    public partial class StartupForm : Form
    {
        public static string newLine = Environment.NewLine;
        private static string _currentItem = string.Empty;
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
            InitializeComponent();
        }

        private void StartupForm_Load(object sender, EventArgs e)
        {
            string[] listOfAvailableLists = WordList.GetLists();
            wordListBox.DataSource = listOfAvailableLists;

            list = WordList.LoadList(listOfAvailableLists[0].ToString());
            UpdateTextBox(list);
            languageSortBox.DataSource = list.Languages;

            wordCount = list.Count();
            countLabel.Text = String.Format($"Antal ord: {wordCount}");
        }

        private void wordListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listContentTextBox.Text = string.Empty;
            string currentItem = wordListBox.SelectedItem.ToString();

            list = WordList.LoadList(currentItem);
            UpdateTextBox(list);

            languageSortBox.DataSource = list.Languages;
            countLabel.Text = String.Format($"Antal ord: {list.Count()}");
        }

        private void languageSortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listContentTextBox.Text = string.Empty;
            CurrentItem = wordListBox.SelectedItem.ToString();
            var list = WordList.LoadList(CurrentItem);
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
                PracticeWordForm practiceWord = new PracticeWordForm(this, list);
                this.Hide();
                practiceWord.Show();
                
            }
        }

        private void addWordsButton_Click(object sender, EventArgs e)
        {

        }

        private void removeWordsButton_Click(object sender, EventArgs e)
        {
            RemoveWordsForm newList = new RemoveWordsForm();
            newList.Show();
            getTextBoxInfo();
        }

        private void openToolStripNewList_Click(object sender, EventArgs e)
        {
            NewListForm newList = new NewListForm();
            newList.Show();
        }

        public void UpdateTextBox(WordList words, int sort = 0)
        {
            List<string> fullText = new List<string>();

            words.List(sort, s => { fullText.Add(String.Join(";", s)); });
            foreach (var word in fullText)
            {
                listContentTextBox.Text += word + newLine;
            }

        }
        public void getTextBoxInfo()
        {
            textBoxInfo = listContentTextBox.Text;

        }
        public static string getListName()
        {
            return CurrentItem;
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}