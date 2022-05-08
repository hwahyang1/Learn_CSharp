using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp._20220507.상속2
{
	public class Dog : Animal // 자동완성(Alt + Enter -> Enter)으로 만들면 되긴 함
	{
		public Dog(string name, string gender, int age) : base(name, gender, age)
		{
		}

		public override void Eat(string food)
		{
			Console.WriteLine(name + "(이)가 " + food + "(을)를 먹고 있습니다.");
		}

		public override void Sleep()
		{
			Console.WriteLine(name + "(이)가 자고 있습니다...");
		}

		public void Bark()
		{
			Console.WriteLine(name + "(이)가 멍멍 짖고 있습니다!");
		}
	}
}
