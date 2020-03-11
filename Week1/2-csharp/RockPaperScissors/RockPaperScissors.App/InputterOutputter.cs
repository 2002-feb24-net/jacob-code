using RockPaperScissors.Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.App
{
    //default access is internal (private to this project)
    // public means other projects can see it
    public class InputterOutputter: IInputterOutputter
    {
        public void Output(string str)
        {
            Console.Write(str);
        }
        public string Input()
        {
            return Console.ReadLine();
        }
    }
}
