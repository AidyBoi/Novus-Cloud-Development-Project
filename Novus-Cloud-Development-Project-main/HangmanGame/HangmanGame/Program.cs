using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman_Game
{
    public static class Program
    {
        private static Form Menu;
        private static Form Game;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Menu = new Entrypoint();
            Game = new GamePage();

            Application.Run(Menu);
        }

        public static void ShowMenu() { Menu.Show(); }
        public static void HideMenu() { Menu.Hide(); }
        public static void ShowGame() {  Game.Show(); }
        public static void HideGame() { Game.Hide(); }
    }
}
