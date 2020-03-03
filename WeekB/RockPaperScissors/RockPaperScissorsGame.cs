using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    class RockPaperScissorsGame
    {
        List<string> roundResults = new List<string>();
        int playedGames = 0;
        int computerChoice = 0;
        int playerChoice = 0;
        public void PlayRound()
        {
            playedGames = roundResults.Count;
            Random rnd = new Random();
            computerChoice = rnd.Next(0,3);
            Console.Write("Rock, Paper, or Scissors? ");
            string input = Console.ReadLine();
            if(input.ToLower()=="rock")
            {
                playerChoice = 0;
            }
            else if(input.ToLower()=="paper")
            {
                playerChoice = 1;
            }
            else if(input.ToLower()=="scissors")
            {
                playerChoice = 2;
            }
            ComputerPrint(computerChoice);
            CheckWinner(playerChoice,computerChoice);
        }
        void CheckWinner(int a, int b)
        {
            //a is playerInput
            //b is computerInput
            //0 = Rock
            //1 = Paper
            //2 = Scissors
            if(a==b)
            {
                Console.WriteLine("It's a Tie!");
                roundResults.Add("tie");
                //tie
            }
            else if (a+2==b || a==b+1)
            {
                //1st condition: Rock beats Scissors
                //2nd condition: Scissors beats Paper or Paper beats Rock
                Console.WriteLine("Player Wins!");
                roundResults.Add("win");
                //a wins
            }
            else
            {
                //Console.WriteLine(b);
                Console.WriteLine("Computer Wins!");
                roundResults.Add("lose");
                //b wins
            }
        }
        void ComputerPrint(int computerChoice)
        {
            if(computerChoice==0)
            {
                Console.WriteLine("Computer Chooses Rock" );
            }
            else if(computerChoice==1)
            {
                Console.WriteLine("Computer Chooses Paper" );
            }
            else
            {
                Console.WriteLine("Computer Chooses Scissors" );
            }
        }
        public void PrintSummary()
        {
            int totalWins = 0;
            int totalLosses = 0;
            int totalTies = 0;
            foreach (string item in roundResults)
            {
                if(item=="win")
                {
                    totalWins++;
                }
                else if(item=="lose")
                {
                    totalLosses++;
                }
                else
                {
                    totalTies++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Wins: " + totalWins + " Loses: "+ totalLosses + " Ties: " + totalTies);
            if(totalWins>totalLosses)
            {
                Console.WriteLine("Player Wins!");
            }
            else
            {
                Console.WriteLine("Computer Wins!");
            }
        }

    }
}

