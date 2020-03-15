using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname = "Sai";
            string lname = "Baba";
            string fullName = fname + " " + lname;
            Console.WriteLine("Greetings {0}", fname);
            Console.WriteLine("Full Name seen is {0}", fullName);
        }
    }
}
