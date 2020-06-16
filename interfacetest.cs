using System;

namespace InterfaceApplication
{

    public interface ITransactions
    {
        void print();
        int sum(int a, int b);
    }
    
    class Program:ITransactions
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
            program.print();
            Console.WriteLine(program.sum(10, 20));
           
        }

        public void print()
        {
            Console.WriteLine("I am in print method");
        }

        public int sum(int a, int b)
        {
            return a + b;
        }
    }
}
