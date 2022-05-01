using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp._20220501.상속1
{
	public class Cat : Animal
	{
		public Cat(string name, string gender, int age) : base(name, gender, age)
		{
		}

		public void Meow()
		{
			Console.WriteLine("{0}(이)가 야옹하고 울었습니다!", name);
		}
	}
}
