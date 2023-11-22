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
    public partial class Entrypoint : Form
    {
        public Entrypoint()
        {
            InitializeComponent();
        }

        private void Entrypoint_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.HideMenu();
            Program.ShowGame();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
