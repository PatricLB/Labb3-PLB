﻿using WordsLibrary;

namespace GUI_App
{
    public partial class RemoveWordsForm : Form
    {
        List<string> newList = new List<string>();
        public RemoveWordsForm()
        {
            InitializeComponent();
            fileNameTextBox.Text = StartupForm.getListName();
            UpdateListBox(StartupForm.list);

        }

        private void removeWordsButton_Click(object sender, EventArgs e)
        {

            foreach (var item in checkedWordsListBox.CheckedItems.OfType<string>().ToList())
            {
                checkedWordsListBox.Items.Remove(item);
                newList.Add(item);
            }
            foreach (var item in newList)
            {
                MessageBox.Show("Item: " + item + " is removed");

            }

        }

        private void saveListButton_Click(object sender, EventArgs e)
        {
            string[] wordToRemove;
            DialogResult d;
            d = MessageBox.Show("Are you sure you want to save the list? All removed words from the list will be removed from the file", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (d.Equals(DialogResult.Yes))
            {
                foreach (var word in newList)
                {
                    wordToRemove = word.Split(";");
                    foreach (var item in wordToRemove)
                    {
                        StartupForm.list.Remove(0, item);
                        StartupForm.list.Save();

                    }
                }
                this.Close();
            }



        }
        private void UpdateListBox(WordList words)
        {
            List<string> fullText = new List<string>();

            words.List(0, s => { fullText.Add(String.Join(";", s)); });
            foreach (var word in fullText)
            {
                checkedWordsListBox.Items.Add(word);
            }
        }

    }
}