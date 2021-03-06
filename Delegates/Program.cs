﻿using System;

namespace ConsoleApplication
{

	// Delegates
	// https://msdn.microsoft.com/en-us/library/ms173171.aspx  
	
	public class Program
	{

		public static void Main(string[] args)
		{
			MyClass obj = new MyClass();
			obj.LongRunningMethod(WriteCurrentIteration);
		}

		static void WriteCurrentIteration(int i)
		{
			Console.WriteLine(i);
		} 
		
	}

	public class MyClass
	{

		public delegate void AwesomeDelegateMethod(int i);

		public void LongRunningMethod(AwesomeDelegateMethod method)
		{
			for (int i = 0; i < 10000; i++)
			{
				method(i);
			}
		}
	}

}
