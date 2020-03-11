using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Library
{
    public interface IRpsStrategy
    {
        int ComputerStrategy(int playerChoice);
        void ComputerPrint(int computerChoice);
    }
}
