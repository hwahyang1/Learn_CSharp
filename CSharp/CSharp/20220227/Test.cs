using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp._20220227
{
	class Test
	{
		static void ClearConsoleWhenEntered()
		{
			Console.Write("계속하려면 아무 키나 누르세요.");
			Console.ReadKey();
			Console.Clear();
		}

		static void Main_20220227_2(string[] args)
		{
			Console.Write("문자열의 길이를 출력합니다. 문자열을 입력하세요: ");
			string input1 = Console.ReadLine();
			Console.WriteLine("입력하신 문자열의 길이는 공백제외 {0}자(공백포함 {1}자) 입니다.\n", (input1.Replace(" ", "")).Length, input1.Length);
			ClearConsoleWhenEntered();

			Console.Write("덧셈을 진행합니다. 수를 띄어쓰기로 입력하세요: ");
			string input2 = Console.ReadLine();
			string[] input2_List = input2.Split(" ");
			int sum = 0;
			foreach (string nowNum in input2_List)
			{
				sum += int.Parse(nowNum);
			}
			Console.WriteLine("{0} = {1}\n", input2.Replace(" ", " + "), sum);
			ClearConsoleWhenEntered();

			Console.Write("문자열에서 공백을 제거합니다. 문자열을 입력하세요: ");
			string input3 = Console.ReadLine();
			Console.WriteLine("{0}\n", input3.Replace(" ", ""));
			ClearConsoleWhenEntered();

			Console.Write("문자열에서 'H'의 개수를 찾습니다. 문자열을 입력하세요: ");
			string input4 = Console.ReadLine();
			Console.WriteLine("입력하신 문자열에 존재하는 'H'는 {0}개 입니다.", ((input4.ToLower()).Split("h")).Length - 1);
		}
	}
}
