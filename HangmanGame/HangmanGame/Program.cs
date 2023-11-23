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
        private static Form WordSelection;

        private static string filePath = "./Resources/WordList.txt";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Menu = new Entrypoint();
            Game = new GamePage(filePath);
            WordSelection = new WordSelection(filePath);

            Application.Run(Menu);
        }

        public static void ShowMenu() { Menu.Show(); }
        public static void ShowGame() { Game.Show(); }
        public static void ShowWordSelection() {
            WordSelection ws = (WordSelection)WordSelection;
            ws.ReloadWordlist();
            WordSelection.Show();
        }

        public static void HideMenu() { Menu.Hide(); }
        
        public static void HideGame() { Game.Hide(); }

        public static void HideAll()
        {
            Menu.Hide();
            Game.Hide();
            WordSelection.Hide();
        }
    }
}
