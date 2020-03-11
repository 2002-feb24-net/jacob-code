using System;
using System.Collections.Generic;

namespace RockPaperScissors.Library
{
    public class RockPaperScissorsGame
    {
        List<string> roundResults = new List<string>();
        int playedGames = 0;
        int computerChoice = 0;
        int playerChoice = 0;
        //we use interface types to allow for flexibility in our code
        //"i need some input and output but i dont care how"
        IInputterOutputter _io;
        IRpsStrategy strategy;

        public RockPaperScissorsGame(IInputterOutputter _io, IRpsStrategy strategy)
        {
            //dependency inversion
            this._io = _io;
            this.strategy = strategy;
        }
        public void PlayRound()
        {
            playedGames = roundResults.Count;
            computerChoice = strategy.ComputerStrategy(playerChoice);
            _io.Output("Rock, Paper, or Scissors? ");
            string input = _io.Input().ToLower();
            if (input == "rock")
            {
                playerChoice = 0;
            }
            else if (input == "paper")
            {
                playerChoice = 1;
            }
            else if (input == "scissors")
            {
                playerChoice = 2;
            }
            strategy.ComputerPrint(computerChoice);
            CheckWinner(playerChoice, computerChoice);
        }
        //Make a IRpsStrategy interface in this project
        // which can decide a move
        // (if you want use a round results parameter)

        //modify this class to use some implementation of that interface
        //just like how it uses implementation of IInputerOutputter for I/O.

        //write two classes that implement that strategy interface
        //for two different strategies

        // in the Program class, instantiate one of your strategies and pass it to the game

        // extra: let user choose which strategy to play against
        void CheckWinner(int a, int b)
        {
            //a is playerInput
            //b is computerInput
            //0 = Rock
            //1 = Paper
            //2 = Scissors
            if (a == b)
            {
                _io.Output("It's a Tie!\n");
                roundResults.Add("tie");
                //tie
            }
            else if (a + 2 == b || a == b + 1)
            {
                //1st condition: Rock beats Scissors
                //2nd condition: Scissors beats Paper or Paper beats Rock
                _io.Output("Player Wins!\n");
                roundResults.Add("win");
                //a wins
            }
            else
            {
                //_io.Output.WriteLine(b);
                _io.Output("Computer Wins!\n");
                roundResults.Add("lose");
                //b wins
            }
        }
        public void PrintSummary()
        {
            int totalWins = 0;
            int totalLosses = 0;
            int totalTies = 0;
            foreach (string item in roundResults)
            {
                if (item == "win")
                {
                    totalWins++;
                }
                else if (item == "lose")
                {
                    totalLosses++;
                }
                else
                {
                    totalTies++;
                }
            }
            _io.Output("\n");
            _io.Output("Wins: " + totalWins + " Loses: " + totalLosses + " Ties: " + totalTies + "\n");
            if (totalWins > totalLosses)
            {
                _io.Output("Player Wins Overall!\n");
            }
            else
            {
                _io.Output("Computer Wins Overall!\n");
            }
        }

    }
}
