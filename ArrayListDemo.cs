using System;
using System.Collections;

/// <summary>
/// Using ArrayList
/// </summary>
namespace ArrayListDemo{

	class App
	{
		static void Main(string[] args)
		{
			ArrayList alist = new ArrayList();
			alist.Add(10);
			alist.Add(20);
			alist.Add(30);
			foreach(int i in alist) {
				Console.WriteLine(i);
			}//end of for each

			Console.ReadKey();
		}
	}
	
}
