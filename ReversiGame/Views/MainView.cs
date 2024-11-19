using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversiGame.Views
{
    public class MainView
    {
        public void Display()
        {
            Console.Clear();
            Console.WriteLine("Reversi Game:");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Check mode for game:");
            Console.WriteLine(" - PvP (game for 2 player");
            Console.WriteLine(" - PvE (game with bot)");

        }
        public string? GetPlayerInput()
        {
            string? input = Console.ReadLine();
            return input;
        }
    }
}
