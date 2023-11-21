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
        public GamePage()
        {
            InitializeComponent();
            alphaInitButtons();
        }

        //initialize alphabet buttons
        private void alphaInitButtons()
        {
            //loop to create and set up alphabet buttons
            for (char c = 'A'; c <= 'Z'; c++)
            {
                Button letter = new Button();
                letter.Text = c.ToString();
                letter.Name = "btn" + c.ToString(); //name the button
                //letter.Click += alphaButton_Click; //add event handler
                alphaPanel.Controls.Add(letter); //add button to panel
            }
        }

        private void alphaButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            //disable button
            clickedButton.Enabled = false;

            //check if letter is in word
            checkLetter(clickedButton.Text);


        }
    }
}
