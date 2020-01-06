using System;

namespace ArrayDemo
{
	class MyArray
	{

		static void Main(string[] args)
		{
			int[] num =new int[4] { 10, 20, 30, 40 };
			foreach(int i in num) {
				Console.WriteLine("Element[{0}]", i);
			}

			Console.ReadKey();
		}
	}

}
