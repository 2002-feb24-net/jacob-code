using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {3,2,1,4,5,6};
            BubbleSort(a);
            Console.WriteLine();
            int[] longest = {6,5,4,3,2,1};
            BubbleSort(longest);
            Console.WriteLine();
            int[] shortest = {1,2,3,4,5,6};
            BubbleSort(shortest);
            Console.WriteLine();
        }
        static void BubbleSort(int[] a)
        {
            bool sorted = false;
            bool noSwaps = true;
            int tempSwap = 0;
            while(sorted==false)
            {
                noSwaps = true;
                for (int i = 1; i < a.Length; i++)
                {
                    if(a[i]<a[i-1])
                    {
                        tempSwap = a[i];
                        noSwaps = false;
                        a[i] = a[i-1];
                        a[i-1] = tempSwap;
                    }
                }
                if(noSwaps==true)
                {
                    sorted=true;
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(" " + a[i]);
            }
        }
    }
}
