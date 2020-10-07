
/*
The lambda expression is a shorter way of representing anonymous method using some special syntax.
*/
using System;
using CSharp.Models;

namespace CSharp.Linq
{
    public class LambdaExpressions
    {
        static void Main1(string[] args)
        {
            AnonymousMethodEx();
            LambdaExpressionsEx();
        }

        private static void LambdaExpressionsEx()
        {
            IsTeenAger isTeenAger = s => s.Age > 12 && s.Age < 20;

            Student stud = new Student() { Age = 25 };

            Console.WriteLine(isTeenAger(stud));
        }

        delegate bool IsTeenAger(Student stud);
        private static void AnonymousMethodEx()
        {

            // Example: Anonymous Method in C#
            IsTeenAger isTeenAger = delegate (Student s) { return s.Age > 12 && s.Age < 20; };

            Student stud = new Student() { Age = 25 };

            Console.WriteLine(isTeenAger(stud));

        }
    }
}