using System;

namespace Acronym
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter multi word term: ");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            AcronymSolver(words);
        }
        static void AcronymSolver(string[] words)
        {
            string temp = "";
            Console.Write("Acronym: ");
            for (int i = 0; i < words.Length; i++)
            {
                temp = words[i];
                Console.Write(char.ToUpper(temp[0]));
            }
        }
    }
}
