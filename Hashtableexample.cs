using System;
using System.Collections;

    class Hashtableexample
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();
            table.Add("Sai", 10);
            table.Add("Ram", 20);
            table.Add("Ashish", 30);
            if (table.ContainsValue(30))
            {
                Console.WriteLine("Value is present");
            }
            ICollection keys = table.Keys;
            foreach(string k in keys)
            {
                Console.WriteLine(k);
            }
        }
    }

