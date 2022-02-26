using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp._20220226
{
	class Array
	{
		static void PrintIntArray(int[] arr, bool changeLine = true)
		{
			Console.Write("{ ");
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i]);
				if (i < arr.Length - 1)
					Console.Write(", ");
			}
			Console.Write(" }");

			if (changeLine)
				Console.Write("\n");
		}

		static void Main_20220226_1(string[] args)
		{
			/* 선언 */
			int[] a;

			/* 초기화 */
			a = new int[10]; // 선언 후 초기화
			int[] b = new int[10]; // 기본
			int[] c = { 2, 4, 6, 8, 10, 12, 14 }; // C 스타일
			int[] d = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // 대체 (기본 + C 스타일, 배열 길이 지정은 선택사항)
			int[] e = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // 대체

			int[] arr = { 2, 4, 6, 8, 10, 12, 14 };
			PrintIntArray(arr);
			arr[4] = 100;
			PrintIntArray(arr);
			Console.WriteLine("arr1의 길이: {0}\n", arr.Length);

			int[] inputs = new int[5];
			int sum = 0;
			for (int i = 0; i < inputs.Length; i++)
			{
				Console.Write("{0}번 칸에 저장 할 수를 입력하세요: ", i);
				inputs[i] = int.Parse(Console.ReadLine());
				sum += inputs[i];
			}
			Console.Write("\n입력한 값은 다음과 같습니다: ");
			PrintIntArray(inputs, false);
			Console.WriteLine(" (총합 {0})", sum);
		}
	}
}
