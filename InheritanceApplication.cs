using System;

namespace InheritanceApplication
{
	class Shape
	{
		protected int width;
		protected int height;
		public void setWidth(int w)
		{
			width = w;
		}//end of function setWidth

		public void setHeight(int h)
		{
			height = h;
		}//end of function to set Height


	}//end of class shape

	class Rectangle : Shape
	{
		public void area()
		{
			int area = width * height;
			Console.WriteLine("Area seen is {0}", area);
			Console.ReadKey();
		}//end of area function
	}//end of Rectangle class

	class RectangleDemo
	{
		static void Main(string[] args)
		{
			Rectangle rectangle = new Rectangle();
			rectangle.setWidth(20);
			rectangle.setHeight(10);
			
			rectangle.area();
		}//end of main
	}//end of class

}//end of namespace
