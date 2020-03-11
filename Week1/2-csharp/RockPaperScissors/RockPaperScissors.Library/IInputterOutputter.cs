using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Library
{
    // interface default access internal (same project)
    // use public to use it in multiple projects
    public interface IInputterOutputter
    {
        //cant write access modifiers on interface members
        //cauuse they have the same one as their containing type (interface)
        void Output(string str);
        string Input();
    }
    // we could improve this interface by following the interface principle
}
