using System;
using System.Collections.Generic;

/// <summary>
/// Using Generics 
/// </summary>
namespace GenricsApp
{
	public class GenericArray<T>
	{
		private T [] array;
		public GenericArray(int size)
		{
			array = new T[size + 1];
		}

		public T getItem(int index)
		{
			return array[index];
		}

		public void setItem(int index, T value)
		{
			array[index] = value;
		}
	}

	class Tester
	{
		static void Main(string []args)
		{
			GenericArray<int> intArray = new GenericArray<int>(5);
			for (int i = 0; i < 5; i++)
			{
				intArray.setItem(i, i * 2);
			}

			Console.WriteLine(intArray.getItem(2));
			Console.ReadKey();

		}
	}
}
