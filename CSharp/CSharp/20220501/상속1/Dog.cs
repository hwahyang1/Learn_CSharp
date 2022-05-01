using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp._20220501.상속1
{
	public class Dog : Animal
	{
		// 생성자 상속
		public Dog(string name, string gender, int age) : base/*부모 클래스 참조*/(name, gender, age)
		{

		}

		public void Bark()
		{
			Console.WriteLine("{0}(이)가 짖고 있습니다!", name);
		}

		// Method Override
		public override void Sleep()
		{
			base.Sleep(); // 부모 메소드 호출 가능
			Console.WriteLine("{0}(이)가 코를 골면서 자고 있습니다...", name);
		}
	}
}
