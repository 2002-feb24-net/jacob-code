using System;
using System.Collections;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayLists();

            // whenever we use a type with <> at the end
            // that is a generic type
            // and the specific thing you p;ut in the <> is called the type parameter.
            var list = new List<int>();
            var list2 = new List<string>();
            var sortedList = new SortedSequence<string>();
            sortedList.Add("asdf");
            sortedList.Add("b");
            sortedList.Add("fsff");
            sortedList.Add("af");
            for(int i = 0; i < 3; i++)
            {
                Console.Write(sortedList[i] + " ");
            }
        }

        static void ArrayLists()
        {
            var arraylist = new ArrayList();
            arraylist.Add(1);
            arraylist.Add(2);
            arraylist.Add(3);
            //arraylist.Add(null);
            arraylist.Add(new ArrayList());
            arraylist.Add("asdg");

            //when used with the non generic IEnumerable interface
            //it will attempt to cast to whatever type you put here
            //       v
            foreach(int item in arraylist)
            {
                //int num2 = (int)item;
                Console.WriteLine($"{item}");
            }
        }
    }
}
