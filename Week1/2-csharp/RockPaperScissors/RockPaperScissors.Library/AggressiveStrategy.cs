using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Library
{
    public class AggressiveStrategy : IRpsStrategy
    {
        IInputterOutputter _io;
        public AggressiveStrategy(IInputterOutputter _io)
        {
            this._io = _io;
        }

        //IInputterOutputter _io;
        public int ComputerStrategy(int playerChoice)
        {
            if(playerChoice == 0)
            {
                return 1;
            }
            else if (playerChoice == 1)
            {
                return 2;
            }
            else
            {
                return 0;
            }
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
