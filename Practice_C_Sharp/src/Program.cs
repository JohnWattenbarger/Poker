using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("New Poker Game");
            Game game = new Game(getNumberOfPlayers());
            Console.Clear();
            game.StartGame();
            
            Program.Pause();
        }

        public static void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public static int getNumberOfPlayers()
        {
            Console.WriteLine("How many players? (2 - 10)");
            int numberOfPlayers = Convert.ToInt32(Console.ReadLine());

            if (numberOfPlayers < 2 || numberOfPlayers > 10){
                Console.WriteLine("Invalid number");
                return getNumberOfPlayers();
            }

            return numberOfPlayers;
        }
    }
   
}
