using System;
using System.Threading;


    class ThreadDemo
    {
        static void Main(string[] args)
        {
        Thread thread = Thread.CurrentThread;
        thread.Name = "Test";
        Console.WriteLine("Thread Name is {0}", thread.Name);
            
        }
    }

