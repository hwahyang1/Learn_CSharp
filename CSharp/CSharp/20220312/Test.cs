using System;
using System.Collections.Generic;
using System.Text;

using CSharp;

namespace CSharp._20220312
{
	class Test
	{
		#region 1번
		static void PrintHello()
		{
			Console.WriteLine("안녕하세요");
		}
		#endregion

		#region 2번
		static void Print(string msg)
		{
			Console.WriteLine(msg);
		}
		#endregion

		#region 3번
		static int Square(int num)
		{
			return num * num;
		}
		#endregion

		#region 4번
		static int Sum(int num1, int num2)
		{
			return num1 + num2;
		}
		#endregion

		#region 5번
		static int GetGCD(int num1, int num2)
		{
			/* Copied from 20220220/Test.cs */

			int a = num2;
			int b = num1 % num2;
			int Temp;

			while (b > 0)
			{
				Temp = b;
				b = a % b;
				a = Temp;
			}

			return a;
		}

		static int GetLCM(int num1, int num2)
		{
			/* 
			 * x * y = GCD(x, y) * LCM(x, y)
			 * ==> (x * y) / GCD(x, y) = LCM(x, y)
			 */
			return (num1 * num2) / GetGCD(num1, num2);
		}
		#endregion

		static void Main_20220312_2(string[] args)
		{
			#region 1번
			PrintHello();
			Duplicate.ClearConsoleWhenEntered();
			#endregion

			#region 2번
			Console.Write("문자열을 입력하세요: ");
			string input1 = Console.ReadLine();
			Console.Clear();
			Print(input1);
			Duplicate.ClearConsoleWhenEntered();
			#endregion

			#region 3번
			Console.Write("숫자를 제곱합니다. 수를 입력하세요: ");
			int input2 = int.Parse(Console.ReadLine());
			Console.Clear();
			int res2 = Square(input2);
			Console.WriteLine("{0}의 제곱은 {1}입니다.", input2, res2);
			Duplicate.ClearConsoleWhenEntered();
			#endregion

			#region 4번
			Console.Write("두 수를 더합니다. 첫 번째 수를 입력하세요: ");
			int input3_1 = int.Parse(Console.ReadLine());
			Console.Clear();
			Console.Write("두 수를 더합니다. 두 번째 수를 입력하세요: ");
			int input3_2 = int.Parse(Console.ReadLine());
			Console.Clear();
			int res3 = Sum(input3_1, input3_2);
			Console.WriteLine("{0}와(과) {1}의 합은 {2}입니다.", input3_1, input3_2, res3);
			Duplicate.ClearConsoleWhenEntered();
			#endregion

			#region 5번
			Console.Write("두 수의 최소공배수를 구합니다. 첫 번째 수를 입력하세요: ");
			int input4_1 = int.Parse(Console.ReadLine());
			Console.Clear();
			Console.Write("두 수의 최소공배수를 구합니다. 두 번째 수를 입력하세요: ");
			int input4_2 = int.Parse(Console.ReadLine());
			Console.Clear();
			int res4 = GetLCM(input4_1, input4_2);
			Console.WriteLine("{0}와(과) {1}의 최소공배수는 {2}입니다.", input4_1, input4_2, res4);
			#endregion
		}
	}
}
