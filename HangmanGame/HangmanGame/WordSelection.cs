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
        
        public const string filePath = "./Resources/WordList.txt";

        public WordSelection()
        {
            InitializeComponent();

            LoadWordsFromFile();

            listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void LoadWordsFromFile()
        {
            try
            {
                // Read text data from the file
                string textData = File.ReadAllText(filePath);

                // Split the text into words
                string[] words = textData.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

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
                // Read all lines from the file
                string[] lines = File.ReadAllLines(filePath);

                // Remove the selected word from the array
                lines = lines.Where(line => line != removedWord).ToArray();

                // Write the modified content back to the file
                File.WriteAllLines(filePath, lines);
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
    }
}
