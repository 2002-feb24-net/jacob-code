using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {3,2,1,4,6};
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
