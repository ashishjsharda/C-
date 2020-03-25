using System;


    class Conditional
    {
    [Obsolete("Don't use overload method ",true)]
    static void OldMethod()
    {
        Console.WriteLine("It is the old method");
    }
    static void NewMethod()
    {
        Console.WriteLine("This is the new method");
    }
        static void Main(string[] args)
        {
        OldMethod();
        NewMethod();
            
        }
    }

