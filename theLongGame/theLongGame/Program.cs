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

            // creates a file path name using the player's name
            filePath = playerName + ".txt";

            // checks to see if a file already exists for a player
            if (File.Exists(filePath))
            { // if a file does exist
                // object created to read data from player's file
                StreamReader playerDataReader = new StreamReader(filePath);
                // file is read and the data is converted to an integer that is stored in playerScore
                playerScore = int.Parse(playerDataReader.ReadLine());
                playerDataReader.Close();
                Console.WriteLine("\nWelcome back " + playerName + ", you already have a score of " + playerScore + "!");
            }
            else
            { // if a file doesn't exist
                Console.WriteLine("\nWelcome " + playerName + "!");
            }

            Console.WriteLine("Your goal is to gain as many points as possible by pressing keys.");
            Console.WriteLine("When you are done playing, press 'ENTER' to end the game");
            Console.WriteLine("Press any key to begin\n");

            // will continuosusly loop until the if statement below is true and breaks out of loop
            while (true)
            {
                // changes the value of keyInput to the most recently pressed key
                var keyInput = Console.ReadKey(true);
                // checks if the most recently pressed key is "enter"
                if (keyInput.Key == ConsoleKey.Enter)
                { // if the most recently pressed key is "enter"
                    // exit the while loop
                    break;
                }
                else
                { // if the most recently pressed key is not "enter"
                    // increase score by 1
                    playerScore++;
                    Console.WriteLine("Your score is: " + playerScore);
                }
            }
            Console.WriteLine("Your final score is: " + playerScore);

            // object created to write data to a player's file
            // creates a file if one doesn't exist yet and overwrites one if one already exists
            StreamWriter playerDataWriter = new StreamWriter(filePath, false);
            // converts playerScore to a string and writes it in the player's file
            playerDataWriter.WriteLine(playerScore.ToString());
            playerDataWriter.Close();
        }
    }
}
