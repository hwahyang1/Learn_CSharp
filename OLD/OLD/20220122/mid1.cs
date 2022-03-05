using System;
using System.Collections.Generic;
using System.Text;

class mid1
{
	static void Main3(string[] args)
	{
		Console.Write("숫자를 입력하세요: ");
		int input = int.Parse(Console.ReadLine());

		switch (input % 2)
		{
			case 0:
				Console.WriteLine("{0}(은)는 짝수입니다.", input);
				break;
			case 1:
			case -1:
				Console.WriteLine("{0}(은)는 홀수입니다.", input);
				break;
			default:
				Console.WriteLine("Undefined");
				break;
		}
	}
}
