using System;
namespace MyLibrary
{
	public abstract class Person
	{
		public string Name { get; set; }
		public void UpdateName(string newName)
		{
			Name = newName;
			
		}

	}
	public class Customer
	{
		public int CustomerId { get; set; }
		public string Name { get; set; }

		public void UpdateName(string newName)
		{
			Name = newName;
		}

		public class Supplier : Person
		{
			public int SupplierId
			{ get; set;}

			}
		}
	}
