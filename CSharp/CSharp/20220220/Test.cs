using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp._20220220
{
	class Test
	{
		static void Main_20220220_2(string[] args)
		{
			Console.Write("수를 입력하세요: ");
			int Input = int.Parse(Console.ReadLine());
			for (int i = 1; i <= 9; i++)
			{
				Console.WriteLine("{0} * {1} = {2}", Input, i, Input * i);
			}
			Console.WriteLine("");

			int Count = 0;
			int Sum = 0;
			string List = "";
			for (int i = 1; i <= Input; i++)
			{
				if (Input % i == 0)
				{
					Count++;
					Sum += i;
					List += i + " ";
				}
			}
			Console.WriteLine("{0}의 약수의 개수는 {1}개 입니다: {2}(총합 {3})\n", Input, Count, List, Sum);

			/* 최대공약수에서의 유클리드 호제법: https://ko.wikipedia.org/wiki/%EC%B5%9C%EB%8C%80%EA%B3%B5%EC%95%BD%EC%88%98#%EC%9C%A0%ED%81%B4%EB%A6%AC%EB%93%9C_%ED%98%B8%EC%A0%9C%EB%B2%95 */

			Console.Write("첫 번째 수를 입력하세요: ");
			int Number1 = int.Parse(Console.ReadLine());
			Console.Write("두 번째 수를 입력하세요: ");
			int Number2 = int.Parse(Console.ReadLine());

			int a = Number2; // 직전 수
			int b = Number1 % Number2; // 나머지
			int Temp;

			while (b > 0)
			{
				//Console.WriteLine(b);
				Temp = b;
				b = a % b;
				a = Temp;
			}
			Console.WriteLine("{0}와(과) {1}의 최대공약수는 {2}입니다.", Number1, Number2, a);
		}
	}
}
