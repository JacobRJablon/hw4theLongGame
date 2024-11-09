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
            string filePath;

            Console.WriteLine("Hello and welcome to...");
            Console.WriteLine("THE LONG GAME");
            Console.WriteLine("What is your name?");
            Console.WriteLine("Enter your name and press 'ENTER'");
            playerName = Console.ReadLine();

            filePath = playerName + ".txt";

            if (File.Exists(filePath) {
                Console.WriteLine("Welcome back" + playerName + "!");
            }
            else
            {
                Console.WriteLine("Welcome " + playerName + "!");
            }

            Console.WriteLine("Your goal is to gain as many points as possible by pressing keys.");
            Console.WriteLine("When you are done playing, press 'ENTER' to end the game");
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
