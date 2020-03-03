using System;

namespace ArrayEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 ={ 1, 2, 3 };
            int[] array2 ={ 1, 2, 3, 4 };
            int[] array3 ={ 1, 2, 3, 4 };
            int[] array4 ={ 0, 2, 3 };

            if(CompareArrays(array1 , array2))
            {
                Console.WriteLine("1 & 2 are equal");
            }
        }
        static Boolean CompareArrays(int[] arr1, int[] arr2)
        {
            if(arr1.Length!=arr2.Length)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if(arr1[i] != arr2[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
