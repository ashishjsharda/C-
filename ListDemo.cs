using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class ListDemo
    {
        static void Main(string[] args)
        {
            LinkedList<String> list = new LinkedList<String>();
            list.AddLast("Amit");
            list.AddLast("Sai");
            list.AddLast("Baba");
            foreach(String str in list)
            {
                Console.WriteLine(str);
            }


        }
    }
}
