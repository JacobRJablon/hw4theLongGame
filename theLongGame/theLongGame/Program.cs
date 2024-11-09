using System;
using System.IO;

namespace theLongGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerName;
            int playerScore = 0;

            Console.WriteLine("Hello and welcome to...");
            Console.WriteLine("THE LONG GAME");
            Console.WriteLine("What is your name?");
            Console.WriteLine("Enter your name and press 'ENTER'");
            playerName = Console.ReadLine();

            Console.WriteLine("Welcome " + playerName + "! The game is about to begin");
            Console.WriteLine("Your goal is to gain as many points as possible.");
            Console.WriteLine("You will gain 1 point for every keypress you make on the keyboard");
            Console.WriteLine("When you are done playing you can press 'ENTER' to end the game");
            Console.WriteLine("Are you ready to start?");
            Console.WriteLine("Press any key to begin");

            while (true)
            {
                var keyInput = Console.ReadKey(true);
                if (keyInput.Key == ConsoleKey.Enter)
                {
                    break;
                }
                else
                {
                    playerScore++;
                    Console.WriteLine("Your score is: " + playerScore);
                }
            }
            Console.WriteLine("Your final score is: " + playerScore);
        }
    }
}
