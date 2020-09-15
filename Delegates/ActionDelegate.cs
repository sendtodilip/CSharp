/*
Action is a delegate type defined in the System namespace. An Action type delegate is the same as Func 
delegate except that the Action delegate doesn't return a value. 
In other words, an Action delegate can be used with a method that has a void return type.
*/

using System;

namespace CSharp.Delegates
{

    // C# Delgate
    public class ActionDelegate
    {
        public delegate void Print(int val);

        static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }

        static void Main1(string[] args)
        {
            Print prnt = ConsolePrint;
            prnt(10);
        }


        // Action Delegate
        static void Main2(string[] args)
        {
            Action<int> printActionDel = ConsolePrint;
            printActionDel(10);
        }

        // Example: Anonymous method with Action delegate
        static void Main3(string[] args)
        {
            Action<int> printActionDel = delegate (int i)
                                        {
                                            Console.WriteLine(i);
                                        };

            printActionDel(10);
        }


        // Example: Lambda expression with Action delegate
        static void Main4(string[] args)
        {

            Action<int> printActionDel = (i) => { Console.WriteLine(i); Console.WriteLine(i);};

            printActionDel(10);
        }
    }
}