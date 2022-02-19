using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp._20220219
{
	class Conditional
	{
		static void Main_20220219_3(string[] args)
		{
			Console.Write("값을 입력하세요: ");
			int input = int.Parse(Console.ReadLine());

			if (input > 10)
			{
				Console.WriteLine("입력된 값이 10보다 큽니다.");
			}
			else if (input == 10)
			{
				Console.WriteLine("입력된 값은 10입니다.");
			}
			else
			{
				Console.WriteLine("입력된 값이 10보다 작습니다.");
			}
		}
	}
}
