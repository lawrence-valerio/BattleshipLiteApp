using System;
using BattleshipLiteLibrary.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();



            Console.ReadLine();
        }

        private static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Battleship Lite");
            Console.WriteLine("Created by Lawrence Valerio");
            Console.WriteLine();
        }

        private static PlayerInfoModel CreatePlayer()
        {
            PlayerInfoModel output = new PlayerInfoModel();

            // Ask user for their name
            output.UsersName = AskForUsersName();

            // Load up the shot grid
            output.ShotGrid
            // Ask the user for their 5 ship placements
            // Clear

            return output;
        }

        private static string AskForUsersName()
        {
            Console.WriteLine("What is your name: ");
            string output = Console.ReadLine();

            return output;
        }
    }
}
