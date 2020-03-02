using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int fizz = 0;
            int buzz = 0;
            int fizzBuzz = 0;
            FizzBuzz(fizz,buzz,fizzBuzz);
        }
        static void FizzBuzz(int fizz, int buzz, int fizzBuzz)
        {
            for (int i = 1; i <= 1000; i++)
            {
                if(i % 3 == 0 && i % 5 != 0)
                {
                    Console.Write("Fizz");
                    fizz++;
                }
                else if(i % 3 != 0 && i % 5 == 0)
                {
                    Console.Write("Buzz");
                    buzz++;
                }
                else if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("Fizzbuzz");
                    fizzBuzz++;
                }
                else
                {
                    Console.Write(" " + i + " ");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write(" Fizz: " + fizz); //267 Fizz
            Console.Write(" Buzz: " + buzz); //134 Buzz
            Console.Write(" Fizzbuzz: " + fizzBuzz); //66 Fizzbuzz
            //Fizz: 267 Buzz: 134 Fizzbuzz: 66
        }
    }
}
