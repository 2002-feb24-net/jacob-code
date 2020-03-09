using System;

namespace MergeSortReforged
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 1, 5, 7, 3, 9, 6, 7};
            
            Console.WriteLine("before sort: [" + string.Join(",", data) + "]");

            MergeSort(data);
            Console.WriteLine("after sort: [" + string.Join(",", data) + "]");
        }
        //1. Split array in half
        //2. Keep doing that for each subarray until you cant anymore cause its size is 1.
        //3. Combine your two arrays
        // keeping the result sorted overall
        static void MergeSort(int[] array)
        {
            //base case
            //if size is 1 ... stop here, its already sorted
            if(array.Length<2)
            {
                return;
            }
            //recursive case
            int middle = array.Length / 2;
            int[] left = SubArray(array, 0, middle);
            int[] right = SubArray(array, middle, array.Length);

            MergeSort(left);
            MergeSort(right);
            //combine them
            int l = 0;
            int r = 0;
            for (int i = 0; i < array.Length; i++)
            {
                //if we finish left or right:
                if(l >= left.Length)
                {
                    array[i] = right[r];
                    r++;
                }
                else if(r >= right.Length)
                {
                    array[i] = left[l];
                    l++;
                }
                else if(left[l]<=right[r]) //but if we havent we should compare
                {
                    array[i] = left[l];
                    l++;
                }
                else
                {
                    array[i] = right[r];
                    r++;
                }
            }
        }
        //array [5,8,4,8]
        //start 0, end 2
        //result should be [5,8]
        static int[] SubArray(int[] array, int start, int end)
        {
            int length = end - start;
            int[] result = new int[length];
            for(int i = 0; i < length; i++)
            {
                result[i] = array[i+start];
            }

            return result;
        }
    }
}
