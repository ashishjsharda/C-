using System;

using System;

namespace first_namespace
{
	class sc
	{
		public void display()
		{
			Console.WriteLine("I am in FC");
		}
	}
}

namespace second_namespace
{
	class sc
	{
		public void display()
		{
			Console.WriteLine("I am in SC");
		}
	}
}

class Application
{
	static void Main(string[] args)
	{
		first_namespace.sc f= new first_namespace.sc();
		second_namespace.sc s = new second_namespace.sc();
		f.display();
		s.display();
		Console.ReadKey();


	}
}
