using System;

namespace OperatorOverloadApplication
{
	class Rectangle
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

		public static  Rectangle operator +(Rectangle rect1, Rectangle rect2)
		{
			Rectangle r = new Rectangle();
			r.width = rect1.width + rect2.width;
			r.height = rect1.height + rect2.height;
			return r;
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
			r2.setWidth(20);
			r2.setHeight(30);
			Console.WriteLine("Area of r2 seen is :{0}", r2.area());
			Rectangle r3 = r1 + r2;
			Console.WriteLine("Area of r3 seen is :{0}", r3.area());
			Console.ReadLine();
		}//end of main
	}//end of class

}//end of namespace
