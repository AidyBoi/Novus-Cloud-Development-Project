using Hangman_Game.Properties;
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
        public GamePage(string filePath)
        {
            InitializeComponent();
            InitialiseButtons();

            game = new GameManager(filePath);

            txtWordFill.Text = game.GetCurrentWordState();
        }

        private void InitialiseButtons()
        {
            for (char c = 'A'; c <= 'Z'; c++)
            {
                Button letter = new Button
                {
                    Text = c.ToString(),
                    Name = $"{c}_button"
                };
                letter.Click += AlphaButton_Click;
                StyliseButton(letter);
                button_grid.Controls.Add(letter);
            }
        }

        private void StyliseButton(Button button)
        {
            button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(22)))), ((int)(((byte)(60)))));
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.Font = new System.Drawing.Font("Rubik SemiBold", 18.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button.ForeColor = System.Drawing.Color.Black;
            button.Size = new System.Drawing.Size(106, 42);
            button.UseVisualStyleBackColor = false;
        }

        private void AlphaButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(sender.ToString());

            Button clickedButton = sender as Button;

            clickedButton.Enabled = false;

            //check if letter is in word and handle game logic
            if (game.CheckGuess(clickedButton.Text[0]))
                txtWordFill.Text = game.GetCurrentWordState();
            else
            {
                numGuesses.Text = game.GuessesLeft.ToString();
                pictureBox1.Image = System.Drawing.Image.FromFile($"./Resources/{game.GuessesLeft}.png");
            }

            if (game.GuessesLeft == 0)
            {
                //game over
                button_grid.Enabled = false;
                MessageBox.Show("Game Over");
            }
            else if (!game.GetCurrentWordState().Contains('-'))
            {
                //game won
                button_grid.Enabled = false;
                MessageBox.Show("You Win!");
            }


        }
        private void ToMenu_Click(object sender, EventArgs e)
        {
            ResetGame();
            Program.HideAll();
            Program.ShowMenu();
        }

        private void ResetGame_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void ResetGame()
        {
            game.ResetGame();
            button_grid.Enabled = true;
            foreach (Button button in (button_grid.Controls))
            {
                button.Enabled = true;
            }
            txtWordFill.Text = game.GetCurrentWordState();
            numGuesses.Text = game.GuessesLeft.ToString();
            pictureBox1.Image = System.Drawing.Image.FromFile($"./Resources/{game.GuessesLeft}.png");
        }

        private void numGuesses_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
