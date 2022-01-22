using System;
using System.Collections.Generic;
using System.Text;

class mid2
{
	static void Main6(string[] args)
	{
		Console.Write("단 수를 입력하세요: ");
		int input = int.Parse(Console.ReadLine());

		for (int i = 1; i < 10; i++)
			Console.WriteLine("{0}*{1} = {2}", input, i, input * i);
	}
}
