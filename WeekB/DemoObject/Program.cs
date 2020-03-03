using System;

namespace DemoObject
{
    class Program
    {
        //Main Program file should be used for user input
        static void Main(string[] args)
        {
            int candyBarAmount = GetStock("Candy Bar");
            Product candyBar = new Product();
            //candyBar.SetDefaultValues();
            //Console.WriteLine(candyBar);
            candyBar.SetValues("123",candyBarAmount,3.9);
            Console.WriteLine(candyBar);

            Product soap = new Product();
            int soapAmount = GetStock("Soap");
            soap.SetValues("10", soapAmount, 4.9);
            Console.WriteLine(soap);

        }
        static int GetStock(string name)
        {
            int quantity;
            do
            {
                System.Console.Write("Enter Quantity of Product " + name + ": ");
                quantity = int.Parse(Console.ReadLine());
            } while(quantity < 0); //if negative quantity, prompt again
            // if we got this far, the user must have finally entered a positie quantity. 
            return quantity;
        }
    }
}
