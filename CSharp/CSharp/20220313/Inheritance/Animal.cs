using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp._20220313.Inheritance
{
	class Animal
	{
		// Attribute
		protected string species = "";
		protected int age = 0;
		protected string name = "";

		// Constructor (Option)
		public Animal(string species, int age, string name)
		{
			this.species = species;
			this.age = age;
			this.name = name;
		}

		// Behavior
		public void Hunting()
		{

		}

		public void Eat()
		{

		}

		public void Sleep()
		{

		}
	}
}
