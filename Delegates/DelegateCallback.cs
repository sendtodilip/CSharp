// Delegate for Callback
using System;
using System.Threading;

namespace CSharp.Delegates
{
    public class DelegateEx1
    {

        static void Main1(string[] args)
        {
            SomeClass x = new SomeClass();
            x.sender = Reciever;
            Thread t = new Thread(new ThreadStart(x.HugeProcess));
            t.Start();
            Console.WriteLine("Program.cs");
            Console.ReadLine();
        }

        static void Reciever(int i)
        {
            Console.WriteLine(i);
        }
    }

    class SomeClass
    {
        public delegate void Sender(int i); //Declearation 
        public Sender sender = null;
        public void HugeProcess()
        {
            for (int i = 0; i < 10000; i++)
            {
                Thread.Sleep(5000);
                sender(i); //Callback
            }
        }
    }
}

