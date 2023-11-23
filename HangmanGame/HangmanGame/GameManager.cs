using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman_Game
{
    public class GameManager
    {
        private string randomWord;
        private string hiddenWord;
        public int GuessesLeft;

        public GameManager(string filePath)
        {
            this.filePath = filePath;

            ResetGame();
        }

        private Random random = new Random();

        public string filePath;
        
        private string GetRandomWord()
        {
            try
            {
                // Get the list of words from the file
                string[] words = File.ReadAllLines(filePath);

                // Check if there are any words in the file
                if (words.Length > 0)
                {
                    // Generate a random index
                    int randomIndex = random.Next(0, words.Length);

                    // Get the random word
                    string randomWord = words[randomIndex];

                    return randomWord.ToUpper();
                }
                else
                {
                    MessageBox.Show("The text file is empty. Add words to get a random word.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting random word: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        public bool CheckGuess(char guessedLetter)
        {
            //if guessedLetter is a character in the randomWord string.
            //replace letter at that index in hiddenWord string with guessedLetter.
            if (randomWord.Contains(guessedLetter))
            {
                for (int i = 0; i < randomWord.Length; i++)
                {
                    if (randomWord[i] == guessedLetter)
                    {
                        hiddenWord = hiddenWord.Remove(i, 1).Insert(i, guessedLetter.ToString());
                    }
                }
                return true;
            }
            else
            {
                GuessesLeft--;
                return false;
            }   
        }

        public string GetCurrentWordState()
        {
            return hiddenWord;
        }

        public void ResetGame()
        {
            //Reset game state and start new round
            randomWord = GetRandomWord();
            hiddenWord = HideWord(randomWord);
            GuessesLeft = 5;
        }

        private string HideWord(string randomWord)
        {
            string hiddenWord = "";
            for (int i = 0; i < randomWord.Length; i++)
            {
                hiddenWord += "-";
            }
            return hiddenWord;
        }

    }
}
