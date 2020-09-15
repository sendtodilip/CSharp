/*
C# - Func Delegate
C# includes built-in generic delegate types Func and Action, so that you don't need to define custom
delegates manually in most cases.

Func is a generic delegate included in the System namespace. It has zero or more input parameters and 
one out parameter. The last parameter is considered as an out parameter.

The Func delegate that takes one input parameter and one out parameter is defined in the System namespace, 
as shown below:
*/

using System;

namespace CSharp.Delegates
{
    public class FuncDelegate
    {
        static int Sum(int x, int y)
        {
            return x + y;
        }

        static void Main1(string[] args)
        {
            Func<int, int, int> add = Sum;

            int result = add(10, 10);

            Console.WriteLine(result);

            // Func with Annonymous method
            Func<int> getRandomNumber = delegate ()
                                        {
                                            Random rnd = new Random();
                                            return rnd.Next(1, 100);
                                        };
            var value = getRandomNumber();
            Console.WriteLine("Random Number: " + value);


            //Func with Lambda Expressions:
            Func<int> getRandomNumber1 = () => new Random().Next(1, 100);
            Console.WriteLine("Labmda exprression - Random Number: " + getRandomNumber1());

            Func<int, int, int> Sum1 = (x, y) => x + y;
            Console.WriteLine("Sum: " + Sum1(10, 20));
        }
    }
}