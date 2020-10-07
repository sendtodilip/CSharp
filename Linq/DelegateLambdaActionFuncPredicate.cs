using System;

namespace CSharp.Linq
{
    public class DelegateLambdaActionFuncPredicate
    {

        // Calling Delegate

        /******************************
        delegate double calAreaPointer(int r);
        static calAreaPointer cpointer = CalculateArea;

        private static double CalculateArea(int r)
        {
            return 3.14 * r * r;
        }

        static void Main(string[] args)
        {
            double area = cpointer.Invoke(20);
        }

        *******************************/


        // Calling using Annonymous method

        /******************************


                delegate double calAreaPointer(int r);

                public static void Main()
                {
                    calAreaPointer cpointer = new calAreaPointer(delegate (int r)
                    {
                        return 3.14 * r * r;
                    });
                    double area = cpointer(20);
                }

        */

        //Using Lambda expressions
        /******************************
        

        delegate double calAreaPointer(int r);
        static void Main(string[] args)
        {
            calAreaPointer cpointer = r => 3.14 * r * r;
            double area = cpointer.Invoke(20);
        }

        *******************************/


        //Using Func - Generic delegate
        /******************************
        

        static void Main(string[] args)
        {
            Func<double, double> cpointer = r => 3.14 * r * r;
            double area = cpointer(20);
        }
        *******************************/



        //Using Action - Generic delegate - return type is void
        /******************************
       
        static void Main(string[] args)
        {
            Action<string> MyAction = y => Console.WriteLine(y);
            MyAction("hello");
        }
        *******************************/


        //Using Predicate - Generic delegate - return type is always boolen
        /******************************
        *******************************/
        static void Main1(string[] args)
        {
            Predicate<string> CheckGreaterThan5 = x => x.Length > 5;
            CheckGreaterThan5("stringvalue");
        }

    }
}