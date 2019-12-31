using System;

namespace InterfaceDemo
{
	interface Shape
	{
		double area();
	}//end of interface
	class Rectangle :Shape
	{
		double width;
		double height;

		public void setWidth(double w)
		{
			width = w;
		}

		public void setHeight(double h)
		{
			height = h;
		}

		public double area()
		{
			return width * height;
		}

		

	}//end of Rectangle


	class Test
	{
		
		static void Main(string[] args)
		{
			Rectangle r1 = new Rectangle();
			Rectangle r2 = new Rectangle();
			r1.setWidth(10);
			r1.setHeight(20);
			Console.WriteLine("Area of r1 seen is :{0}",r1.area());
			Console.ReadLine();
		}//end of main
	}//end of class

}//end of namespace
