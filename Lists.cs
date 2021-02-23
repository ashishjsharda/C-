using System;
using System.Collections.Generic;

namespace IoDemo
{

    class Lists
    {

        


        static void Main(string[] args)
        {
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(1); // adding elements using add() method
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);
            primeNumbers.ForEach((x) => Console.WriteLine(x ));
            

        }


    }

    
}
