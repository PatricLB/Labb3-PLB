using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WordsLibrary;

namespace GUI_App
{
    public partial class Form1 : Form
    {
        public string newLine = Environment.NewLine;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] listOfAvailableLists = WordList.GetLists();

            wordListBox.DataSource = listOfAvailableLists;
            var list = WordList.LoadList(listOfAvailableLists[0].ToString());
            UpdateTextBox(list);
            languageSortBox.DataSource = list.Languages;

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

            List<string> fullText = new List<string>();
            list.List(value, s => { fullText.Add(String.Join(";", s)); });
            foreach (var word in fullText)
            {
                listContentBox.Text += word + newLine;
            }
        }
        private void UpdateTextBox(WordList words)
        {
            List<string> fullText = new List<string>();
            string newLine = Environment.NewLine;

            words.List(0, s => { fullText.Add(String.Join(";", s)); });
            foreach (var word in fullText)
            {
                listContentBox.Text += word + newLine;
            }
            
        }
    }
}