using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp._20220305
{
	class RightTriangle4
	{
		static void Main_20220305_6(string[] args)
		{
			/*
				* * * * *
				  * * * *
					* * *
					  * *
						*
			 */

			Console.Write("삼각형의 크기를 입력하세요: ");
			int size = int.Parse(Console.ReadLine());
			Console.Clear();

			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < i; j++)
				{
					Console.Write("  ");
				}
				for (int k = 0; k < size - i; k++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
		}
	}
}
