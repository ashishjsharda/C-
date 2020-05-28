using System;

namespace ConsoleApp2
{

    
    class Max
    {
        public int findMax(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            return num2;
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Max number is :{0}", program.findMax(10, 20));
           
        }
    }
}
