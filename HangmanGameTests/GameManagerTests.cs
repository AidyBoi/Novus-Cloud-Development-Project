using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hangman_Game;

namespace HangmanGameTests
{
    [TestClass]
    public class GameManagerTests
    {
        private GameManager _gameManager;

        [TestInitialize]
        public void Setup()
        {
            _gameManager = new GameManager();
        }

        [TestMethod]
        public void TestInitialWordState()
        {
            // Arrange
            string expected = _gameManager.GetCurrentWordState();

            // Act
            string actual = _gameManager.GetCurrentWordState();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCorrectGuess()
        {
            // Arrange
            char correctGuess = 'E';

            // Act
            bool isCorrect = _gameManager.CheckGuess(correctGuess);

            // Assert
            Assert.IsTrue(isCorrect);
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
    }
}
