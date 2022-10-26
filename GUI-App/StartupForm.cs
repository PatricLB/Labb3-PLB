using WordsLibrary;

namespace GUI_App
{
    public partial class StartupForm : Form
    {
        public static string newLine = Environment.NewLine;
        static string currentItem = string.Empty;
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
            wordCount = list.Count();
            UpdateTextBox(list);
            languageSortBox.DataSource = list.Languages;
            countLabel.Text = String.Format($"Antal ord: {wordCount}");
        }

        private void wordListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listContentTextBox.Text = string.Empty;
            string currentItem = wordListBox.SelectedItem.ToString();
            //string value = wordListBox.SelectedIndex.ToString();

            list = WordList.LoadList(currentItem);
            UpdateTextBox(list);

            languageSortBox.DataSource = list.Languages;
            countLabel.Text = String.Format($"Antal ord: {list.Count()}");
        }

        private void languageSortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listContentTextBox.Text = string.Empty;
            currentItem = wordListBox.SelectedItem.ToString();
            var list = WordList.LoadList(currentItem);
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
            return currentItem;
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}