using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Conquest_of_the_Crimson_Towers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = @"   
   ______                                  __           ____   __  __            ______     _                               __                              
  / ____/___  ____  ____ ___  _____  _____/ /_   ____  / __/  / /_/ /_  ___     / ____/____(_)___ ___  _________  ____     / /_____ _      _____  __________
 / /   / __ \/ __ \/ __ `/ / / / _ \/ ___/ __/  / __ \/ /_   / __/ __ \/ _ \   / /   / ___/ / __ `__ \/ ___/ __ \/ __ \   / __/ __ \ | /| / / _ \/ ___/ ___/
/ /___/ /_/ / / / / /_/ / /_/ /  __(__  ) /_   / /_/ / __/  / /_/ / / /  __/  / /___/ /  / / / / / / (__  ) /_/ / / / /  / /_/ /_/ / |/ |/ /  __/ /  (__  ) 
\____/\____/_/ /_/\__, /\__,_/\___/____/\__/   \____/_/     \__/_/ /_/\___/   \____/_/  /_/_/ /_/ /_/____/\____/_/ /_/   \__/\____/|__/|__/\___/_/  /____/  
                    /_/                                                                                                                                     ";

            Console.WriteLine(title);
            Console.WriteLine();
            Console.WriteLine("(Stretch the title till its readable correctly, from that way on, play the game with that window size)");
            Console.WriteLine();
            Console.WriteLine("                                Press 'Enter' to start the game");

            var key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
                Console.Clear();
            else
                Environment.Exit(0);

            int hp = 100;
            int wr = 400;

            Console.Write("                                   Enter the name of your character: ");
            string name = Console.ReadLine();

            Console.Clear();

            string intro = $"{name} is a great warrior and a knight of Lord Hypnos himself, one day after a large and long lasting battle with a legion of Orcs, he came out alone but victorious, he ventured into the Forest of the Mist to find his way home";
            string[] introsplit = intro.Split(' ');
            foreach (var i in introsplit)
            {
                Console.Write(i + " ");
                Thread.Sleep(wr);

            }
            Console.ReadKey();


        }
    }
}
