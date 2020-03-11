using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAndInterface
{
    class MyClass : Interface1
    { 
        public string myString { get; }
        public int myInt1 = 1;

        private int myInt2 = 10;
        private string MyString2 = "I am a private string";

        public static string myString3 = "I am a static string";

        public MyClass() { }
        public MyClass(int myInt1, string myString)
        {
            this.myInt1 = myInt1;
            this.myString = myString;
        }

        public void PrintPrivateFields()
        {
            Console.WriteLine($"This is my int {myInt2} This is my string {MyString2}");
        }
        public string InstanceMethod()
        {
            return MyString2;
        }
        public void refMethod(ref int x)
        {
            //ref allows you to change the original variable you sent in
            x = x + 100;
            Console.WriteLine(x);
        }

        public void OutMethod(int number, out int outVar) //out is similar to ref but for instantiating a new object (aka cant send variable data in)
        {
            outVar = number + 333;
        }

        public void ParameterArrayMethod(string s, params int[] arg)
        {
            foreach(var item in arg)
            {
                if(item == 0)
                {
                    Console.WriteLine("Its 0.");
                }
            }
        }

        public double returnDouble(int a)
        {
            return a+=a;
        }
    }
}
