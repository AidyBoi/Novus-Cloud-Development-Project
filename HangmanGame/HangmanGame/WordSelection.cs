using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Hangman_Game
{
    public partial class WordSelection : Form
    {
        
        private string filePath;

        public WordSelection(string filePath)
        {
            InitializeComponent();

            this.filePath = filePath;

            LoadWordsFromFile();

            listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        public void ReloadWordlist()
        {
            LoadWordsFromFile();
        }

        private void LoadWordsFromFile()
        {
            try
            {
                string[] words = GetUniqueWordsFromList(GetWordsFromFile(this.filePath));

                listView2.Items.Clear();

                // Add words to the ListView
                foreach (string word in words)
                {
                    listView2.Items.Add(word);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading words: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string[] GetWordsFromFile(string filePath)
        {
            return File.ReadAllText(filePath).Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        }

        private string[] GetUniqueWordsFromList(string[] words)
        {
            Dictionary<string, string> uniqueWords = new Dictionary<string, string>();
            foreach (string word in words)
            {
                if (!uniqueWords.ContainsKey(word.ToUpper()))
                {
                    uniqueWords.Add(word.ToUpper(), word);
                }
            }
            List<string> result = new List<string>();
            foreach (KeyValuePair<string,string> pair in uniqueWords)
            {
                result.Add(pair.Value);
            }
            return result.ToArray();    
        }

        private void WordsListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) // Check if it's a right-click
            {
                ListViewHitTestInfo hitTest = listView2.HitTest(e.Location);

                if (hitTest.Item != null)
                {
                    // Remove the selected word
                    listView2.Items.Remove(hitTest.Item);
                }
            }
        }  
        
        private void Removebutton_Click(object sender, EventArgs e)
        {
            // Remove the selected word from ListView and update text file
            if (listView2.SelectedItems.Count > 0)
            {
                string selectedWord = listView2.SelectedItems[0].Text;

                // Remove the item from the ListView
                listView2.Items.Remove(listView2.SelectedItems[0]);

                // Update the text file
                UpdateTextFile(selectedWord);
            }
            else
            {
                MessageBox.Show("Please select a word to remove.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void EditWordsBTN_Click(object sender, EventArgs e)
        {
            // Add the entered word to ListView and update text file
            string newWord = addTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(newWord))
            {
                // Add the word to the ListView
                listView2.Items.Add(newWord);

                // Update the text file
                AddToTextFile(newWord);

                // Clear the TextBox
                addTextBox.Clear();

                listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            else
            {
                MessageBox.Show("Please enter a word to add.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddToTextFile(string newWord)
        {
            try
            {
                // If word is already in list do not add
                if (GetWordsFromFile(this.filePath).Contains(newWord)) { return; }
                // Append the new word to the text file with a newline character
                File.AppendAllText(filePath, $"{newWord}\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating text file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTextFile(string removedWord)
        {
            try
            {
                // Read all word from the file
                string[] words = GetWordsFromFile(this.filePath);
                StringBuilder sb = new StringBuilder();

                // Remove the selected word from the array
                words = words.Where(word => word != removedWord).ToArray();
                
                foreach (string word in GetUniqueWordsFromList(words))
                {
                    sb.AppendLine(word);
                }

                // Write the modified content back to the file
                File.WriteAllText(filePath, sb.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating text file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void label1_Click(object sender, EventArgs e) { }

        private void addTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void WordSelection_Load(object sender, EventArgs e)
        {

        }

        private void toMenu_Click(object sender, EventArgs e)
        {
            Program.HideAll();
            Program.ShowMenu();
        }

        private void resetWordlist_Click(object sender, EventArgs e)
        {
            // HARDCODED DEFAULT WORDS FILE
            listView2.Items.Clear();
            string[] words = GetUniqueWordsFromList(GetWordsFromFile("./Resources/DefaultWordlist.txt"));
            StringBuilder sb = new StringBuilder();

            // Add words to the ListView
            foreach (string word in words)
            {
                listView2.Items.Add(word);
                sb.AppendLine(word);
            }

            File.WriteAllText(filePath, sb.ToString());
        }
    }
}
