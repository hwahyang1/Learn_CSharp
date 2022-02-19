using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp._20220219
{
	class Test
	{
		static void Main_20220219_2(string[] args)
		{
			Console.Write("숫자를 입력하세요: ");
			int input1 = int.Parse(Console.ReadLine());
			Console.WriteLine("{0}(은)는 {1}입니다.\n", input1, (input1 % 2 == 0) ? "짝수" : "홀수");

			Console.Write("현재 년도를 입력하세요: ");
			int input2 = int.Parse(Console.ReadLine());
			Console.WriteLine("{0}년은 {1}입니다.\n", input2, (input2 % 4 == 0) ? (input2 % 100 == 0) ? (input2 % 400 == 0) ? "윤년" : "평년" : "윤년" : "평년");

			int a = 194; // 0000 1100 0010(2)
			Console.WriteLine(a << 1); // 0001 1000 0100(2) 388(10) <-- 194*2
			Console.WriteLine(a >> 1); // 0110 0001(2) 97(10) <-- 194/2

			Console.WriteLine("");

			int b = 38; // 0010 0110(2)
			Console.WriteLine(b << 1); // 0100 1100(2) 76(10) <-- 38*2
			Console.WriteLine(b >> 1); // 0001 0011(2) 19(10) <-- 38/2
		}
	}
}
