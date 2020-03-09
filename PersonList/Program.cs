using System;
using System.Collections.Generic;
namespace PersonList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person> 
            { 
                new Person("Harry",22),
                new Person("Sarah",77),
                new Person("Bob",66),
                new Person("Jim",33),
                new Person("Sam",43),
                new Person("Harry",22)
            };
            Console.Write("List contents: ");
            foreach (var item in list)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Check Duplicate: " + Duplicate(list));
            list = InsertionSort(list);
            Console.Write("List sorted contents: ");
            foreach (var item in list)
            {
                Console.Write(item.ToString() + " ");
            }

        }
        static bool Duplicate(List<Person> list)
        {
            HashSet<string> temp = new HashSet<string>();
            foreach (var item in list)
            {
                if(temp.Add(item.ToString()))
                {

                }
                else
                {
                    return true;
                }
            }
            return false;
        }
        static List<Person> InsertionSort(List<Person> list)
        {
            //insertion sort is sorting through the list by checking the left side of the list
            // keep shifting through the list until the element is greater than the preceding element
            // and insert at that position
            // A bubble sort compares pairs and then continues sorting the list while an insertion sort
            // traverses a list and shifts it until it finds an elements sorted position
            Person temp = new Person("temp",0);
            int tempIndex = 0;
            for (int i = 0; i < list.Count; i++)
            {
                tempIndex = i;
                temp = list[i];
                while(tempIndex > 0 && String.Compare(temp.ToString(),list[tempIndex-1].ToString()) < 0)
                {
                    list[tempIndex] = list[tempIndex-1];
                    tempIndex = tempIndex - 1;

                }
                list[tempIndex] = temp;
            }
            return list;
        }
    }
}
