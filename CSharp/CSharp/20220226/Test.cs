using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp._20220226
{
    class Test
	{
		static void ClearConsoleWhenEntered()
        {
			Console.Write("계속하려면 엔터를 입력하세요.");
			Console.ReadLine();
			Console.Clear();
        }

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

		static void Main(string[] args) //_20220226_2
        {
			int[] inputs1 = new int[10];
			for (int i = 0; i < inputs1.Length; i++)
			{
				Console.Write("{0}번 칸에 저장 할 수를 입력하세요: ", i);
				inputs1[i] = int.Parse(Console.ReadLine());
			}
			Console.Write("\n입력한 값은 다음과 같습니다: ");
			PrintIntArray(inputs1);
			Console.Write("\n");
			ClearConsoleWhenEntered();

			Console.Write("배열의 크기를 지정하세요: ");
			int len = int.Parse(Console.ReadLine());
			int[] inputs2 = new int[len];
			for (int i = 0; i < inputs2.Length; i++)
			{
				Console.Write("{0}번 칸에 저장 할 수를 입력하세요: ", i);
				inputs2[i] = int.Parse(Console.ReadLine());
			}
			Console.Write("\n입력한 값은 다음과 같습니다: ");
			PrintIntArray(inputs2);
			Console.Write("\n");
			ClearConsoleWhenEntered();

			Console.Write("input1의 값은 다음과 같습니다: ");
			PrintIntArray(inputs1);
			Console.Write("\n");

			int[] inputs3 = new int[10];
			inputs3 = inputs1;
			Console.Write("복사된 input3의 값은 다음과 같습니다: ");
			PrintIntArray(inputs3);
			Console.Write("\n");
		}
    }
}
