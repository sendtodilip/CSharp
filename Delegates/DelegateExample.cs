/*
What if we want to pass a function as a parameter? How does C# handles the callback functions or event handler?
The answer is - delegate.


The delegate is a reference type data type that defines the method signature. You can define variables of
delegate, just like other data type, that can refer to any method with the same signature as the delegate.

There are three steps involved while working with delegates:

Declare a delegate
Set a target method
Invoke a delegate
*/

using System;

namespace CSharp.Delegates
{
    public delegate void MyDelegate(string msg); //declaring a delegate

    class Program
    {
        static void Main1(string[] args)
        {
            MyDelegate del = ClassA.MethodA;
            del("Hello World");

            del = ClassB.MethodB;
            del("Hello World");

            del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
            del("Hello World");
        }
    }

    public class ClassA
    {
        public static void MethodA(string message)
        {
            Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
        }
    }

    class ClassB
    {
        public static void MethodB(string message)
        {
            Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
        }
    }
}