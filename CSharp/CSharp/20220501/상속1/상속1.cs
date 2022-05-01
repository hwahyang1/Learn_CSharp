using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp._20220501.상속1
{
	public class 상속1
	{
		static void Main_20220501_1(string[] args)
		{
			Dog dog = new Dog("멈뭄미", "M", 3);
			Cat cat = new Cat("고먐미", "F", 2);

			dog.Bark();
			dog.Eat("사료");
			dog.Sleep();

			Console.WriteLine("");

			cat.Meow();
			cat.Eat("츄르");
			cat.Sleep();
		}
	}
}
