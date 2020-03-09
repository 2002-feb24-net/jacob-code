using System;

namespace Fibonnaci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FibonacciIterative(5));
            
        }
        static int FibonacciIterative(int length)
        {
            int[] result = new int[length+1];
            result[0] = 0;
            result[1] = 1;
            for (int i = 2; i <= length; i++)
            {
                result[i] = result[i-1] + result[i-2]; 
            }
            return result[length];
        }
        //get the ith fibonacci number
        //n: 0 1 1 2 3 5
        //i: 0 1 2 3 4 5
        static int FibonnaciNumber(int i)
        {
            if(i==0)
            {
                return 0;
            }
            else if(i==1)
            {
                return 1;
            }
            //recursion is just a method calling itself
            return FibonnaciNumber(i-2) + FibonnaciNumber(i-1);
        }
        //recursive method:
        //if problem is simple
        //return answer directly (base case) (non recursive case)
        //otherwise:
        //breakdown the problem
        //somehow to pieces that are closer to the base case (recursive case)
        //call this method again to solve that simpler case 
    }
}
