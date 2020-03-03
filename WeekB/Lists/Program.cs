using System;
using System.Collections.Generic;
namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Like arrays, each List instance can contain
            // just one particular type of data, which you choose when you create the list
            // unlike arrays, lists can grow and shrink in size
            List<int> list = new List<int>();
            //Starts empty by default
            int howMany = list.Count;
            list.Add(123);
            int firstItem = list[0];
            list[0] = 5;
            
        }
    }
}
