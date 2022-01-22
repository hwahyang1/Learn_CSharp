using System;
using System.Collections.Generic;
using System.Text;

class @while
{
	static void Main5(string[] args)
	{
		Console.Write("반복 횟수를 입력하세요: ");
		int input = int.Parse(Console.ReadLine());

		int i = 0;
		int sum = 0;
		while (i <= input)
		{
			sum += i;
			i++;
		}

		Console.WriteLine(sum);
	}
}
