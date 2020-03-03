using System;
//Made by Jacob Koch
namespace Day2Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1();
            System.Console.WriteLine("Please input staircase size:");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            Exercise2(number);
            System.Console.WriteLine("Please input Collatz number:");
            string input2 = Console.ReadLine();
            int collatz = int.Parse(input2);
            Exercise3(collatz);

        }
        static void Exercise1()
        {
            int number = 8;
            int count = number;
            int spacescount = 0;
            int hashcount = 0;
            String[] stairs = new string[number + 1];
            for (int i = number; i > 0; i--)
            {
                stairs[i] = "";
                if (i == number)
                {
                    for (int n = 0; n < number; n++)
                    {
                        stairs[i] = stairs[i] + "#";
                    }
                }
                else
                {
                    spacescount = number - i; //hashcount
                    hashcount = i; //spacecount
                    for (int n = 0; n < hashcount; n++)
                    {
                        stairs[i] = stairs[i] + "#";
                    }
                    for (int m = 0; m < spacescount; m++)
                    {
                        stairs[i] = " " + stairs[i];
                    }
                }
                count--;
            }
            for (int i = 0; i < number; i++)
            {
                System.Console.WriteLine(stairs[i]);
            }

        }
        static void Exercise2(int input)
        {
            int number = input;
            int count = number;
            int spacescount = 0;
            int hashcount = 0;
            String[] stairs = new string[number + 1];
            for (int i = number; i > 0; i--)
            {
                stairs[i] = "";
                if (i == number)
                {
                    for (int n = 0; n < number; n++)
                    {
                        stairs[i] = stairs[i] + "#";
                    }
                }
                else
                {
                    spacescount = number - i;
                    hashcount = i;
                    for (int n = 0; n < hashcount; n++)
                    {
                        stairs[i] = stairs[i] + "#";
                    }
                    for (int m = 0; m < spacescount; m++)
                    {
                        stairs[i] = " " + stairs[i];
                    }
                }
                count--;
            }
            for (int i = 0; i < number; i++)
            {
                System.Console.WriteLine(stairs[i]);
            }
        }
        static void Exercise3(int number)
        {
            int i = number;
            while(i>1)
            {
                if(i%2==0)
                {
                    System.Console.WriteLine(i/2);
                    i=(i/2);
                }
                else
                {
                    System.Console.WriteLine(((i*3)+1));
                    i=((i*3)+1);
                }
            }
        }
    }
}
