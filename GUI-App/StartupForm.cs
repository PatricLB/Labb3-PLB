using WordsLibrary;

namespace GUI_App
{
    public partial class StartupForm : Form
    {
        public string newLine = Environment.NewLine;
        public StartupForm()
        {
            InitializeComponent();
        }

        private void StartupForm_Load(object sender, EventArgs e)
        {
            string[] listOfAvailableLists = WordList.GetLists();

            wordListBox.DataSource = listOfAvailableLists;
            var list = WordList.LoadList(listOfAvailableLists[0].ToString());
            UpdateTextBox(list);
            languageSortBox.DataSource = list.Languages;
            countLabel.Text = String.Format($"Antal ord: {list.Count()}");
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void wordListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listContentBox.Text = string.Empty;
            string currentItem = wordListBox.SelectedItem.ToString();
            //string value = wordListBox.SelectedIndex.ToString();

            var list = WordList.LoadList(currentItem);
            UpdateTextBox(list);

            languageSortBox.DataSource = list.Languages;
            countLabel.Text = String.Format($"Antal ord: {list.Count()}");
        }

        private void listContentBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void trainWordsButton_Click(object sender, EventArgs e)
        {

        }

        private void languageSortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listContentBox.Text = string.Empty;
            string currentItem = wordListBox.SelectedItem.ToString();
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
        private void UpdateTextBox(WordList words, int sort = 0)
        {
            List<string> fullText = new List<string>();
            string newLine = Environment.NewLine;

            words.List(sort, s => { fullText.Add(String.Join(";", s)); });
            foreach (var word in fullText)
            {
                listContentBox.Text += word + newLine;
            }

        }

        private void removeWordsButton_Click(object sender, EventArgs e)
        {

        }
    }
}