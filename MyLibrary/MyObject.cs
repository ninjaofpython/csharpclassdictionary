using System;
namespace Playground
{
	public class MyObject
		{
			public MyObject()
			{
				_number1 = 15;
				_number2 = 15;
			}
			public MyObject(int number1, int number2)
			//EXample of a constructor
			{
				_number1 = number1;
				_number2 = number2;

			}
			int _number1 = 5;
			int _number2 = 5;


			public int number1
			{
				get
				{
					return _number1;
				}
				set
				{
					_number1 = value;
				}
			}
			public int number2
			{
				get
				{
					return _number2;
				}
				set
				{
					_number2 = value;
				}
			}
			public int number3
			{
				get
				{
					return _number1 + _number2;
				}
			}


			//This method has parameters unlike the overloaded method below the params are int number1 and int number 2
			public int Calculate(int number1, int number2)
			{
				return number1 + number2;

			}

			//An eXample of an overloaded method notice no parameters unlike the method above
			public int Calculate()
			{
				return _number1 + _number2;

			}



			public string MyStringProperty { get; set; }
			public string MyMethod()
			{
				return "some value";

			}
		}
	}
