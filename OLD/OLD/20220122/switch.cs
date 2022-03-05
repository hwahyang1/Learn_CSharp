using System;
using System.Collections.Generic;
using System.Text;

class @switch
{
	static void Main2(string[] args)
	{
		Console.Write("Input[num]: ");
		int num = int.Parse(Console.ReadLine());

		switch (num)
		{
			case 1:
				Console.WriteLine("num => 1");
				break;
			case 2:
				Console.WriteLine("num => 2");
				break;
			case 3:
				Console.WriteLine("num => 3");
				break;
			default:
				Console.WriteLine("Undefined");
				break;
		}
	}
}
