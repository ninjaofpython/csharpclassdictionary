using System;
using System.Collections.Generic;


namespace Playground
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var customer = new MyLibrary.Customer();

			MyLibrary.ICalculate function = new MyLibrary.AddCalculate();


			var result = function.PerformCal(10, 10);

			MyObject myObject = new MyObject();
			//Below is an overloaded constructor
			MyObject myObject2 = new MyObject(10, 10);
			myObject.Calculate(10, 10);




			//Console.WriteLine("Number 1 is " + myObject.number1);
			//Console.WriteLine("Number 2 is " + myObject.number2); 
			//Console.WriteLine("object 1 property is " + myObject.number3);
			//Console.WriteLine("object 2 property is " + myObject2.number3);

			Console.WriteLine("Interface Calc result is: " + result);

			Console.ReadLine();
		}
	}

}
