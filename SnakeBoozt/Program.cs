using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnakeBoozt.Classes;

namespace SnakeBoozt
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamehandler game = new Gamehandler();

            while(true)
            {
                Console.WriteLine("Welcome to SnakeBoozt! Choose from the menu below.\n");
                Console.WriteLine("1) {0}\n2) {1}\n", "Play game", "Exit game");

                int menuValue = int.Parse( Console.ReadLine() );
                switch(menuValue)
                {
                    case 1:
                        game.Start();
                        break;
                    case 2:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }

                Console.Clear();
            }
        }
    }
}
