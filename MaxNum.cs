using System;

namespace MaxNum
{
	class MaxNumber
	{
		public int findMax(int num1, int num2)
		{
			if (num1 > num2)
			{
				return num1;
			}
			else
				return num2;
		}
		static void Main(string []args)
		{
			MaxNumber max = new MaxNumber();
			Console.WriteLine("Max Value is {0}",max.findMax(10, 20));
			Console.ReadKey();
		}
	}//end of class
}//end of namespace
