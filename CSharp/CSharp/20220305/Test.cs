using System;
using System.Collections.Generic;
using System.Text;

using CSharp;

namespace CSharp._20220305
{
	class Test
	{
		static void Main_20220305_7(string[] args)
		{
			Console.Write("입력한 수까지의 소수를 구합니다. 2 이상의 수를 입력하세요: ");
			int input = int.Parse(Console.ReadLine());
			Console.Clear();

			/* 에라토스테네스의 체: https://ko.wikipedia.org/wiki/%EC%97%90%EB%9D%BC%ED%86%A0%EC%8A%A4%ED%85%8C%EB%84%A4%EC%8A%A4%EC%9D%98_%EC%B2%B4 */

			int sum = 0;
			int[] list = new int[input - 1];
			for (int i = 2; i <= input; i++) // 리스트 초기화
			{
				list[i - 2] = i;
			}

			for (int i = 0; i < list.Length; i++)
			{
				if (list[i] != -1) // 소수가 아니어서 지워진 값은 -1로 처리
				{
					for (int j = 0; j < list.Length; j++) // 처음부터 돌면서 list[i] 의 배수이면(자신 제외) -1로 처리
					{
						if (list[j] % list[i] == 0 && list[j] != list [i])
						{
							list[j] = -1;
						}
					}
				}
			}
			Console.Write("2부터 {0} 사이의 소수는 다음과 같습니다: ", input);
			for (int i = 0; i < list.Length; i++)
			{
				if (list[i] != -1)
				{
					sum += 1;
					Console.Write(list[i]);
					if (i < list.Length - 1)
						Console.Write(" ");
				}
			}
			Console.WriteLine(" (총 {0}개)", sum);
			Duplicate.ClearConsoleWhenEntered();

			/* --------------------------------------- */

			Console.Write("피라미드의 높이를 입력하세요: ");
			int size_pyramid = int.Parse(Console.ReadLine());
			Console.Clear();
			for (int i = 0; i < size_pyramid; i++)
			{
				for (int j = 1; j < size_pyramid - i; j++)
				{
					Console.Write("  ");
				}

				Console.Write("* ");
				for (int k = 0; k < i; k++)
				{
					Console.Write("* * ");
				}
				Console.WriteLine();
			}
			Duplicate.ClearConsoleWhenEntered();

			/* --------------------------------------- */

			Console.Write("다이아몬드의 크기를 입력하세요: ");
			int size_diamond = int.Parse(Console.ReadLine());
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine(" __   __     ______   ___   _______  __   __  _______  __    _  ______     __   __  \n|  | |  |   |      | |   | |   _   ||  |_|  ||       ||  |  | ||      |   |  | |  | \n|  | |  |   |  _    ||   | |  |_|  ||       ||   _   ||   |_| ||  _    |  |  | |  | \n|  | |  |   | | |   ||   | |       ||       ||  | |  ||       || | |   |  |  | |  | \n|__| |__|   | |_|   ||   | |       ||       ||  |_|  ||  _    || |_|   |  |__| |__| \n __   __    |       ||   | |   _   || ||_|| ||       || | |   ||       |   __   __  \n|__| |__|   |______| |___| |__| |__||_|   |_||_______||_|  |__||______|   |__| |__|\n");

			// 윗줄
			for (int i = 0; i < size_pyramid; i++)
			{
				Console.Write(" ");

				for (int j = 1; j < size_pyramid - i; j++)
				{
					Console.Write(" ");
				}

				Console.Write("*");
				for (int k = 0; k < i; k++)
				{
					Console.Write("**");
				}
				Console.WriteLine();
			}

			// 중간줄
			Console.Write("*");
			for (int i = 0; i < size_pyramid; i++)
			{
				Console.Write("**");
			}
			Console.WriteLine();

			// 아랫줄 (역방향)
			for (int i = size_pyramid - 1; i >= 0; i--)
			{
				Console.Write(" ");

				for (int j = 1; j < size_pyramid - i; j++)
				{
					Console.Write(" ");
				}

				Console.Write("*");
				for (int k = 0; k < i; k++)
				{
					Console.Write("**");
				}
				Console.WriteLine();
			}

			Console.ResetColor();
		}
	}
}
