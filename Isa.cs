using System;

namespace Demo
{
    class Isa
    {

        public static void save(Object obj)
        {
            if(obj is string)
            {
                Console.WriteLine("Object is string");
            }
            else
            {
                Console.WriteLine("Object is not a string ");
            }
        }
        
        static void Main(string[] args)
        {
            save("Sainath");
            save(12);

        }
    }

    
}
