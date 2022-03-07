using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp._20220305
{
	class MultiplicationTable
	{
		static void Main_20220305_1(string[] args)
		{
			for (int i = 1; i <= 9; i++)
			{
				for (int j = 1; j <= 9; j++)
				{
					Console.WriteLine("{0} X {1} = {2}", i, j, i * j);
				}
				Console.WriteLine();
			}
		}
	}
}
