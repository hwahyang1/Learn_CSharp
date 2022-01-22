using System;
using System.Collections.Generic;
using System.Text;

class repeat
{
	static void Main4(string[] args)
	{
		Console.Write("반복 횟수를 입력하세요: ");
		int input = int.Parse(Console.ReadLine());

		int sum = 0;
		for (int i = 0; i <= input; i++)
			sum += i;
		
		Console.WriteLine(sum);
	}
}