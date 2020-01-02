using System;

namespace StringDemo
{
	class StringApp
	{

		static void Main(string[] args)
		{
			string str = "Hello World";
			char[] letters = { 'H', 'e', 'l', 'l', 'o' };
			string greetings = new string(letters);
			Console.WriteLine(str);
			Console.WriteLine(greetings);
			Console.ReadKey();
		}
	}

}
