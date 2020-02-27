using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a string: ");
            string input = Console.ReadLine();
            Reverse(input);
        }
        static void Reverse(string input)
        {
            int length = input.Length;
            string reversedString = "";
            for (int i = length-1; i >= 0; i--)
            {
                reversedString += input[i];
            }
            Console.WriteLine("Reversed String: " + reversedString);
        }
    }
}
