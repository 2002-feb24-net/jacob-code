using System;

namespace InheritanceMammalCatHuman
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //make a mammal

            //Mammal is abstract so you cant

            //make a human
            Human bob = new Human();
            bob._color = "blue";
            bob.breathsWith = "pizza";
            bob.avgHeartRate = 50;
            bob.hasFur = true;

            Console.WriteLine($"{bob.FavoriteColor()}. He breathes with {bob.breathsWith}. His heartrate is {bob.GetAvgHeartRate()}. And Bob has fur? == {bob.hasFur}");
            //make a cat
            Cat cat = new Cat(true, 4, 180, "tuna");
            Console.WriteLine($"Cat breaks {cat.BreakStuff()}. Cat breathes with {cat.breathsWith}. Cat's heartrate is {cat.GetAvgHeartRate()}. And cat has fur? == {cat.hasFur}");
            //set the unique cat characteristic
            cat.victim = "urn of grandma's ashes";

            //set the unique human characteristic

            bob._color = "red";
            //get the unique cat characteristic
            Console.WriteLine("Cat breaks " + cat.BreakStuff());

            //get the unique chuman characteristic
            Console.WriteLine(bob.FavoriteColor());

            //call the unique cat action
            cat.Sleep();

            //call the unique human action
            bob.Work();

            //which type of inheritance is this?
            //Hierarchical inheritance

            //change the cats heartrate
            cat.avgHeartRate = 0;


        }
    }
}
