using System;

namespace ArrayModifier
{
    class Program
    {
        // accept input from user, list of numbers separated by spaces
        // interpret that as an int array
        // print the array's values back to the user
        // ask the user for some operation
        // print the array's new values to the user.
        static void Main(string[] args)
        {
            string input = GetInput("Type Input String: ");
            int[] array = InterpretStringAsArray(input);
            input = GetInput("Choose Operation: (Positive or Swap) ");
            if(input.ToLower().Equals("positive"))
            {
                array = PositiveArray(array);
            }
            else if(input.ToLower().Equals("swap"))
            {
                array = SwapArray(array);
            }
            PrintArray(array);
        }

        static void PrintArray(int[] a)
        {
            Console.Write("PrintArray: ");
            for(int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        static int[] InterpretStringAsArray(string str)
        {
            string[] temp = str.Split(' ');
            int[] y = new int[temp.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                y[i]=int.Parse(temp[i]);
            }
            return y;
        }

        // any method is going to have
        // 1. a name
        // 2. a return value: either nothing (void), or some type e.g. int
            // what result does the method need to send back to the code that uses this method.
        // 3. a list of parameters (maybe empty)
            // does the method need any input from the code that uses it to do its job.
        static string GetInput(string question)
        {
            Console.Write(question);
            string input = Console.ReadLine();
            return input;
        }

        static int Add(int a, int b)
        {
            int result = a + b;
            return result;
            // you use "return" to send the return value back to the
            // code that calls this method.
        }

        static int[] PositiveArray(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i]<0)
                {
                    input[i] = input[i] * (-1);
                }
            }
            return input;
        }
        
        static int[] SwapArray(int[] input)
        {
            int temp;
            //swaps every other entry
            for (int i = 0; i < input.Length; i+=2)
            {
                if((i+2)<input.Length)
                {
                    temp = input[i];
                    input[i]=input[i+2];
                    input[i+2]=temp;
                }
            }
            return input;
        }
    }
}
