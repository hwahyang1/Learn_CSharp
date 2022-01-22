using System;
using System.Collections.Generic;
using System.Text;

class condition
{
	static void Main1(string[] args)
	{
		Console.Write("Input[a]: ");
		int a = int.Parse(Console.ReadLine());
		Console.Write("Input[b]: ");
		int b = int.Parse(Console.ReadLine());

		if (a < b)
		{
			Console.WriteLine("a < b");
		}
		/*else if (a == b)
		{
			Console.WriteLine("a == b");
		}*/
		else if (a > b)
		{
			Console.WriteLine("a > b");
		}
		else
		{
			Console.WriteLine("Undefined");
		}
	}
}
