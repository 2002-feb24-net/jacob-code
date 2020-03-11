using System;

namespace ClassAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass1 = new MyClass(1 , "howdy");
            Console.WriteLine(myClass1.myInt1);
            Console.WriteLine("This is the int => {0}\n This is the String => {1}", myClass1.myInt1, myClass1.myString);
            myClass1.PrintPrivateFields();
            Console.WriteLine(MyClass.myString3);
            int y = 11;
            myClass1.refMethod(ref y);
            Console.WriteLine($"This is the new y: {y}"); //y has changed
            myClass1.OutMethod(33, out int outV);
            Console.WriteLine($"the outvariable is {outV}");
            myClass1.ParameterArrayMethod("test", 1,2,3,4,5);
            Console.WriteLine(myClass1.returnDouble(500));
        }
    }
}
