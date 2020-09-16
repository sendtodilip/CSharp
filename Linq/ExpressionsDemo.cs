/*
The lambda Expression can be assigned to the Func or Action type delegates to process over in-memory 
collections. The .NET compiler converts the lambda expression assigned to Func or Action type delegate into 
executable code at compile time.

LINQ introduced the new type called Expression that represents strongly typed lambda expression. 
It means lambda expression can also be assigned to Expression<TDelegate> type. The .NET compiler converts the
lambda expression which is assigned to Expression<TDelegate> into an Expression tree instead of executable code. 
This expression tree is used by remote LINQ query providers as a data structure to build a runtime query out of
it (such as LINQ-to-SQL, EntityFramework or any other LINQ query provider that implements IQueryable<T> 
interface).
*/

using System;
using System.Linq.Expressions;
using CSharp.Models;

namespace CSharp.Linq
{

    // Define Func delegate for an expression in C#

    public class ExpressionsDemo
    {
        static void Main1(string[] args)
        {
            ExpressionsDemoEx();
        }

        private static void ExpressionsDemoEx()
        {

            Func<Student, bool> isTeenAger = s => s.Age > 12 && s.Age < 20;

            // Define Expression in C#
            // you can convert the above Func type delegate into an Expression by wrapping Func 
            // delegate with Expresson, as below:

            Expression<Func<Student, bool>> isTeenAgerExpr = s => s.Age > 12 && s.Age < 20;

            // Invoke an Expression

            //compile Expression using Compile method to invoke it as Delegate
            Func<Student, bool> isTeenAger1 = isTeenAgerExpr.Compile();

            //Invoke
            bool result = isTeenAger1(new Student() { StudentID = 1, StudentName = "Steve", Age = 20 });

            Console.WriteLine($"Result: = {result}");
        }

    }



}