using System;

namespace CSharp.Linq
{
    public class ExpressionsDemo1
    {

        static void Main1(string[] args)
        {
            ExpressionsDemo();
        }

        private static void ExpressionsDemo()
        {
            // Lambda expression as executable code.
            Func<int, bool> deleg = i => i < 5;
           
            // Invoke the delegate and display the output.
            Console.WriteLine("deleg(4) = {0}", deleg(4));

            // Lambda expression as data in the form of an expression tree.
            System.Linq.Expressions.Expression<Func<int, bool>> expr = i => i < 5;

            // Compile the expression tree into executable code.
            Func<int, bool> deleg2 = expr.Compile();
            
            // Invoke the method and print the output.
            Console.WriteLine("deleg2(4) = {0}", deleg2(4));

            /*  This code produces the following output:

                deleg(4) = True
                deleg2(4) = True
            */
        }



    }
}