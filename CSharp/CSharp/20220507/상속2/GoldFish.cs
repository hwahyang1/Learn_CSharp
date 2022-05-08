using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp._20220507.상속2
{
	public class GoldFish : Animal
	{
		public GoldFish(string name, string gender, int age) : base(name, gender, age)
		{
		}

		public override void Eat(string food)
		{
			Console.WriteLine(name + "(이)가 " + food + "(을)를 뻐끔뻐끔 먹고 있습니다.");
		}

		public override void Sleep()
		{
			Console.WriteLine(name + "(이)가 산호에 숨어서 자고 있습니다...");
		}

		public void Puff()
		{
			Console.WriteLine(name + "(이)가 뻐끔거리고 있습니다!");
		}
	}
}
