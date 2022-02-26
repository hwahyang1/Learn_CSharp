using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp._20220220
{
	class Iteration
	{
		static void Main_20220220_1(string[] args)
		{
			int sum1 = 0;
			for (int i = 1; i <=100; i++)
			{
				//Console.WriteLine("현재 {0}번째 반복 중입니다.", i);
				sum1 += i;
			}
			Console.WriteLine("1~100까지의 합: {0}", sum1);

			int sum2 = 0;
			int j = 1;
			while (j <= 100)
			{
				sum2 += j;
				j++;
			}
			Console.WriteLine("1~100까지의 합: {0}", sum2);

			int sum3 = 0;
			int k = 1;
			do
			{
				//Console.WriteLine("{0} = {0} + {1}", sum3, k);
				sum3 += k;
				k++;
			} while (k <= 100);
			Console.WriteLine("1~100까지의 합: {0}", sum3);

			int l = 1;
			for (; ; l++ )
			{
				Console.WriteLine(l);
				if (l > 50000)
					continue; // 조건식을 안거치고 for 문의 맨 위로 보냄
			}

			/*for (; ; )
			{

			}

			while (true)
			{

			}

			do
			{

			} while (true);*/
		}
	}
}
