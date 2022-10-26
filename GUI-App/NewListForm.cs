using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WordsLibrary;

namespace GUI_App
{
    public partial class NewListForm : Form
    {

        private List<string> languages = new List<string>();

        public NewListForm()
        {
            InitializeComponent();
        }

        private void addLanguageButton_Click(object sender, EventArgs e)
        {
            languages.Add(userInputLanguageBox.Text);
            languagesToBeAddedBox.DataSource = languages.ToArray();
            userInputLanguageBox.Text = string.Empty;
        }

        private void removeLanguageButton_Click(object sender, EventArgs e)
        {
            string currentItem = languagesToBeAddedBox.SelectedItem.ToString();
            if (languages.Contains(currentItem))
            {
            languages.Remove(currentItem);
            languagesToBeAddedBox.DataSource = languages.ToArray();
            }
            else
                MessageBox.Show("Language does not exist in list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void NewListForm_Load(object sender, EventArgs e)
        {

        }

        private void addWordsButton_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show($"Are you sure you want to continue with the list creation? File will be saved", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (d.Equals(DialogResult.Yes))
                MessageBox.Show("Next up, creating the file! To bad its form is not implemented yet.");

        }

        // Consider using this in another form class
        private void CreateFileInDir()
        {
            string fileName = GetNewFileName();
            string fullSökVäg = Path.Combine(WordList.folderPath, fileName + ".dat");
            List<String> language = GetNewLanguages();

            if (!File.Exists(fullSökVäg))
            {
                var newList = new WordList(fileName, language.ToArray());
                using (StreamWriter sr = new StreamWriter(fullSökVäg))
                {
                    foreach (string lang in language)
                    {
                        sr.Write($"{lang};");
                    }
                }


                //AddWordToList(newList);
                newList.Save();

                //return newList;
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
