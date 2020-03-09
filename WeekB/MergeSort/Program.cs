using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // Merge Sort takes an array
            // Splits the array in half
            // Calls itself and split the halves in half
            // Repeats until base case of two elements
            // Sorts two elements
            int[] a = {7,6,4,2,5,3};
            MergeSort merge = new MergeSort(a);
            merge.StartSort(0,a.Length-1);
            Console.WriteLine(merge.ToString());
        }
    }
}
