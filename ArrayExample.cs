using System;

    class ArrayExample
    {
        static void Main(string[] args)
        {
        int[] arr = new int[10];
        for(int i=0;i<arr.Length;i++)
        {
            arr[i] = i;
            Console.WriteLine(i);
        }
        Console.WriteLine("Using For Each");
        foreach (int j in arr)
        {
            Console.WriteLine(j);
        }

        }
    }

