using System;
using System.Collections.Generic;
namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionaries
            //Unordered
            //no duplicates (no key duplicates, can have value duplicates)
            //fast lookup
            //work on a key value pair basis
            //Dictionary<string,int>
            //           key, value
            var dict = new Dictionary<string, int>()
            {
                ["Bill"] = 59
            };
            var dict2 = new Dictionary<string, List<int>>();
            //indexing
            dict["Bob"] = 91;
            //instead of using a dictionary,
            //we could use a class

            string[] names = { "A", "B", "C"};
            int[] grades = { 1, 2, 3 };
            foreach(var item in dict)
            {
                string key = item.Key;
                int value = item.Value;
            }
            //dict = new Dictionary<string, int>()
        }
        class Student
        {

        }
    }
}
