using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp._20220219
{
	class Conditional2
	{
		static void Main_20220219_4(string[] args)
		{
			Console.Write("값을 입력하세요: ");
			int input = int.Parse(Console.ReadLine());

			switch (input)
			{
				case 15:
					Console.WriteLine("입력된 수를 5로 나누면 3이 됩니다.");
					break;
				case 1000:
					Console.WriteLine("한국 지폐의 최소 단위입니다.");
					break;
				default:
					Console.WriteLine("입력된 값은 {0}입니다.", input);
					break;
			}
		}
	}
}
