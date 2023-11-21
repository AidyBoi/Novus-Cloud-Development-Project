using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_Game
{
    internal class GameManager
    {
        private string randomWord;
        private string hiddenWord;
        public int GuessesLeft;

        public GameManager()
        {
            //initialize variables
            randomWord = GetRandomWord();
            hiddenWord = HideWord(randomWord);
            GuessesLeft = 5;
        }

        private string GetRandomWord()
        {
            randomWord = "test"; //to be replaced with actual random word selection.
            return randomWord.ToUpper();
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
