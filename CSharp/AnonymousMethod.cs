/*
As the name suggests, an anonymous method is a method without a name. Anonymous methods in C# can be 
defined using the delegate keyword and can be assigned to a variable of delegate type.

*/
using System;

namespace CSharp
{
    public class AnonymousMethod
    {
        public delegate void Print(int value);

        static void Main1(string[] args)
        {
            Print print = delegate (int val)
            {
                Console.WriteLine("Inside Anonymous method. Value: {0}", val);
            };

            print(100);
        }
    }
}