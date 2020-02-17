using System;
using System.Collections;

/**
 * Using Inheritance
 * @author asharda
 * */
class Vehicle
{
	public String brand = "Toyota";
	/// <summary>
	/// Display Type of Vehicle
	/// </summary>
	public void type()
	{
		Console.WriteLine("Type of Vehicle is Car");
	}
}

class Car : Vehicle
{
	public String model = "Corolla";

	/// <summary>
	/// Display Car Model
	/// </summary>
	public void display()
	{
		Console.WriteLine("Model os the car is Corolla");
	}
}

class Program
{
	static void Main(string[] args)
	{
		Car car = new Car();
		car.type();
		car.display();
		Console.ReadKey();
	}

}
