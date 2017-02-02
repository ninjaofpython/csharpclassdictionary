using System;
namespace MyLibrary
{
	public class AddCalculate : MyLibrary.ICalculate
	{
		public int PerformCal(int n1, int n2)
		{
			return n1 + n2;
		}
	}
	public class SubtractCalculate : MyLibrary.ICalculate
	{
		public int PerformCal(int n1, int n2)
		{
			return n1 - n2;
		}
	}
	public class MulitplyCalculate : MyLibrary.ICalculate
	{
		public int PerformCal(int n1, int n2)
		{
			return n1 * n2;
		}
		}
	public class DivisionCalculate : MyLibrary.ICalculate
	{
		public int PerformCal(int n1, int n2)
		{
			return n1 / n2;
		}
	}
}
