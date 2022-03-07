using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp._20220305
{
	class RightTriangle3
	{
		static void Main_20220305_5(string[] args)
		{
			/*
						*
					  * *
					* * *
				  * * * *
				* * * * *
			 */

			Console.Write("삼각형의 크기를 입력하세요: ");
			int size = int.Parse(Console.ReadLine());
			Console.Clear();

			for (int i = 0; i < size; i++)
			{
				for (int j = 1; j < size - i; j++)
				{
					Console.Write("  ");
				}
				for (int k = 0; k <= i; k++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
		}
	}
}
