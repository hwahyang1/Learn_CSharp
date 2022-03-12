using System;
using System.Collections.Generic;
using System.Text;

using CSharp;

namespace CSharp._20220226
{
	class Test
	{
		static int[] GetIntArray(int len)
		{
			int[] arr = new int[len];
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write("{0}번 칸에 저장 할 수를 입력하세요: ", i);
				arr[i] = int.Parse(Console.ReadLine());
				Console.Clear();
			}
			return arr;
		}

		static void Main_20220226_2(string[] args)
		{
			int[] inputs1 = GetIntArray(10);
			Console.Write("입력한 값은 다음과 같습니다: ");
			Duplicate.PrintArray(inputs1);
			Console.Write("\n");
			Duplicate.ClearConsoleWhenEntered();

			Console.Write("배열의 크기를 지정하세요: ");
			int len = int.Parse(Console.ReadLine());
			int[] inputs2 = GetIntArray(len);
			Console.Write("입력한 값은 다음과 같습니다: ");
			Duplicate.PrintArray(inputs2);
			Console.Write("\n");
			Duplicate.ClearConsoleWhenEntered();

			Console.Write("input1의 값은 다음과 같습니다: ");
			Duplicate.PrintArray(inputs1);
			int[] inputs3 = new int[10];
			inputs3 = inputs1;
			Console.Write("복사된 input3의 값은 다음과 같습니다: ");
			Duplicate.PrintArray(inputs3);
			Console.Write("\n");
		}
	}
}
