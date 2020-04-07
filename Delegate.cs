using System;
delegate int NumberChanger(int n);

    class Delegate
    {
    static int num = 10;
    public static  int sum(int num1)
    {
        num = num + num1;
        return num;
    }

    public static int mul(int num1)
    {
        num = num * num1;
        return num;
    }
        static void Main(string[] args)
        {

        NumberChanger addition = new NumberChanger(sum);
        Console.WriteLine(addition(5));
        NumberChanger multiply = new NumberChanger(mul);
        Console.WriteLine(multiply(20));

    }
    }

