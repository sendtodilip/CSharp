using System;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp.Misc
{
    public class AsyncAwaitTask
    {
        private static string result;
        static void Main1()
        {
            MessageFromTheMethod();
            Console.WriteLine($"This is returned from the method: {result}");
            Console.ReadLine();
        }

        private static async Task<string> MessageFromTheMethod()
        {
            await Task.Delay(5);
            // Thread.Sleep(5);
            result = "Hello World";
            return "something";
        }
    }
}