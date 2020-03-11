using RockPaperScissors.Library;
using System;

namespace RockPaperScissors.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //should be able to run multiple rounds
            //and keep track of the amount of wins
            var game = new RockPaperScissorsGame();
            bool readyToQuit = false;
            while (readyToQuit == false)
            {
                Console.Write("Do you want to play a round? ");
                string input = Console.ReadLine();
                if (input == "n")
                {
                    readyToQuit = true;
                }
                else
                {
                    game.PlayRound();
                    //that method should play a round and print the result
                }
            }

            game.PrintSummary();
            //that method should print out a summary of rounds.
            //wins and loses
        }
    }
}