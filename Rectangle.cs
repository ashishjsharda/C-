using System;

namespace RectangleApplication {
	class Rectangle
	{
		double length ;
		double width ;

		public void initialize()
		{

			length = 10;
			width = 20;
		}

			public double GetArea()
		{
			
			return length * width;
		}
		public void display()
		{
			Console.WriteLine("Length: {0}", length);
			Console.WriteLine("Width: {0}", width);
			Console.WriteLine("Area: {0}", GetArea());
		}
		static void Main(string []args)
		{
			Rectangle r = new Rectangle();
			r.initialize();
			r.display();
			Console.ReadKey();
		}
	}
}
