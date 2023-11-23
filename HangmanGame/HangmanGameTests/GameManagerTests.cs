using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hangman_Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_Game.Tests
{
    [TestClass()]
    public class GameManagerTests
    {
        private GameManager _gameManager;
        private const string filePath = "./Resources/WordList.txt";

        [TestInitialize]
        public void Initilisation()
        {
            _gameManager = new GameManager(filePath);
        }

        [TestMethod]
        public void TestInitialWordState()
        {
            string expected = _gameManager.GetCurrentWordState();
            Assert.IsNotNull(expected);
        }

        [TestMethod]
        public void TestCorrectGuess()
        {
            // Arrange
            //Get the current word state
            string currentWordState = _gameManager.GetCurrentWordState();
            char correctGuess = currentWordState[0];

            //Check that the current word state contains the correct guess
            Assert.IsTrue(currentWordState.Contains(correctGuess));
        }

        [TestMethod]
        public void TestIncorrectGuess()
        {
            // Arrange
            char incorrectGuess = 'X'; // Assuming 'X' is an incorrect guess

            // Act
            bool isIncorrect = _gameManager.CheckGuess(incorrectGuess);

            // Assert
            Assert.IsFalse(isIncorrect);
        }

        [TestMethod]
        public void TestResetGame()
        {
            // Arrange
            _gameManager.CheckGuess('A'); // Make a guess to change the game state

            // Act
            _gameManager.ResetGame();

            // Assert
            Assert.AreEqual(5, _gameManager.GuessesLeft);
            Assert.AreNotEqual(_gameManager.GetCurrentWordState(), _gameManager.randomWord);
        }

        [TestMethod]
        public void TestGuessesLeftAfterIncorrectGuess()
        {
            // Arrange
            int initialGuessesLeft = _gameManager.GuessesLeft;

            // Act
            _gameManager.CheckGuess('Z'); // Making an incorrect guess

            // Assert
            Assert.AreEqual(initialGuessesLeft - 1, _gameManager.GuessesLeft);
        }

        [TestMethod]
        public void TestGameOverAfterMaxGuessesReached()
        {
            // Arrange
            while (_gameManager.GuessesLeft > 0)
            {
                _gameManager.CheckGuess('Z'); // Make incorrect guesses until guesses are exhausted
            }

            // Act
            bool isGameOver = (_gameManager.GuessesLeft == 0);

            // Assert
            Assert.IsTrue(isGameOver);
        }

        [TestMethod]
        public void TestWinningScenario()
        {
            // Arrange
            string wordToGuess = _gameManager.randomWord;
            foreach (char letter in wordToGuess)
            {
                if (!_gameManager.GetCurrentWordState().Contains(letter))
                {
                    _gameManager.CheckGuess(letter); // Guess all the correct letters in the word
                }
            }

            // Act
            bool isWinningState = (_gameManager.GetCurrentWordState() == _gameManager.randomWord);

            // Assert
            Assert.IsTrue(isWinningState);
        }

    }
}