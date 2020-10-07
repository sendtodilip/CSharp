// From Callback to Broadcast - Multicast delegates
using System;
using System.Threading;

namespace CSharp.Delegates
{
    public class DelegateMulticast
    {

        static void Main1(string[] args)
        {
            SomeClass1 x = new SomeClass1();
            // Subscribe - multicast delegate
            x.sender += Reciever;
            x.sender += Reciever1;
            x.sender += Reciever2;
            // Unsubscribe
            // x.sender -= Reciever2;
            Thread t = new Thread(new ThreadStart(x.HugeProcess));
            t.Start();
            Console.WriteLine("Program.cs");
            Console.ReadLine();
        }

        static void Reciever(int i)
        {
            Console.WriteLine("Rec " + i.ToString());
        }
        static void Reciever1(int i)
        {
            Console.WriteLine("Rec1 " + i.ToString());
        }
        static void Reciever2(int i)
        {
            Console.WriteLine("Rec2 " + i.ToString());
        }
    }

    class SomeClass1
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

