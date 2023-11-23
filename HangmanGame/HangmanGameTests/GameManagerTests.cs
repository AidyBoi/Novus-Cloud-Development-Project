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
        private GameManager gameManager;
        private const string filePath = "./Resources/WordList.txt";

        [TestInitialize]
        public void Initilisation()
        {
            gameManager = new GameManager(filePath);
        }

        [TestMethod()]
        public void Word_From_Wordlist()
        {
            Assert.AreEqual("", gameManager.GetCurrentWordState());
        }
    }
}