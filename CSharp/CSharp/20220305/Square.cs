using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp._20220305
{
	class Square
	{
		static void Main_20220305_2(string[] args)
		{
			Console.Write("사각형의 크기를 입력하세요: ");
			int size = int.Parse(Console.ReadLine());
			Console.Clear();

			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
		}
	}
}
