using System;

namespace Day4Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string: ");
            string str = Console.ReadLine();
            Console.WriteLine("Please enter a number: ");
            int numb = int.Parse(Console.ReadLine());
            SubstringSolver(str,numb);
        }
        static void SubstringSolver(string str, int numb)
        {
            for (int index = 0; index <= (str.Length-numb); index++)
            {
                System.Console.Write(str.Substring(index,numb) + " ");
            }
        }
    }
}
