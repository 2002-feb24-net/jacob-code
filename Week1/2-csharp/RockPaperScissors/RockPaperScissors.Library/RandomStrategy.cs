using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Library
{
    public class RandomStrategy : IRpsStrategy
    {
        IInputterOutputter _io;
        public RandomStrategy(IInputterOutputter _io)
        {
            this._io = _io;
        }
        public int ComputerStrategy(int playerChoice)
        {
            Random rnd = new Random();
            int computerChoice = rnd.Next(0, 3);
            if (computerChoice == 0)
            {
                _io.Output("Computer Chooses Rock\n");
            }
            else if (computerChoice == 1)
            {
                _io.Output("Computer Chooses Paper\n");
            }
            else
            {
                _io.Output("Computer Chooses Scissors\n");
            }
            return computerChoice;
        }
        public void ComputerPrint(int computerChoice)
        {
            if (computerChoice == 0)
            {
                _io.Output("Computer Chooses Rock\n");
            }
            else if (computerChoice == 1)
            {
                _io.Output("Computer Chooses Paper\n");
            }
            else
            {
                _io.Output("Computer Chooses Scissors\n");
            }
        }
    }
}
