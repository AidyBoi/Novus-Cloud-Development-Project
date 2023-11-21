using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman_Game
{
    public partial class GamePage : Form
    {
        private GameManager game;
        public GamePage()
        {
            InitializeComponent();
            game = new GameManager();
            AlphaInitButtons();
            txtWordFill.Text = game.GetCurrentWordState();
        }

        //initialize alphabet buttons
        private void AlphaInitButtons()
        {
            //loop to create and set up alphabet buttons
            for (char c = 'A'; c <= 'Z'; c++)
            {
                Button letter = new Button
                {
                    Text = c.ToString(),
                    Name = "btn" + c.ToString() //name the button
                };
                letter.Click += AlphaButton_Click; //add event handler
                alphaPanel.Controls.Add(letter); //add button to panel
            }
        }

        private void AlphaButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button clicked");
            Button clickedButton = sender as Button;

            //disable button
            clickedButton.Enabled = false;

            //check if letter is in word and handle game logic
            if (game.CheckGuess(clickedButton.Text[0]))
            {
                //update hidden word
                txtWordFill.Text = game.GetCurrentWordState();
            }
            else
            {
                //update hangman image
                numGuesses.Text = game.GuessesLeft.ToString();
            }   


        }
    }
}
