using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp._20220219
{
    class Test2
    {
		static void Main_20220219_5(string[] args)
		{
			Console.Write("현재 년도를 입력하세요: ");
			int input1 = int.Parse(Console.ReadLine());
			string result = "평년";
			if (input1 % 4 == 0)
				if (input1 % 100 == 0)
					if (input1 % 400 == 0)
						result = "윤년";
				else
					result = "윤년";
			Console.WriteLine("{0}년은 {1}입니다.\n", input1, result);

			int input2;
			while (true)
            {
				Console.Write("값을 입력하세요: ");
				input2 = int.Parse(Console.ReadLine());
				if (input2 < 1 || input2 > 100)
					Console.WriteLine("1~100 사이의 값을 입력하세요.");
				else
					break;
			}
			if (75 <= input2)
				Console.WriteLine("당첨");
			else
				Console.WriteLine("꽝");


			Console.Write("연령 제한을 입력하세요: ");
			int input3 = int.Parse(Console.ReadLine());
			switch(input3)
            {
				case 0:
					Console.WriteLine("전체이용가입니다. 모두가 이용할 수 있습니다.");
					break;
				case 12:
					Console.WriteLine("12세 이용가입니다. 부모의 관리감독이 필요할 수 있습니다.");
					break;
				case 15:
					Console.WriteLine("15세 이용가입니다. 알아서 잘 할 수 있을 것입니다.");
					break;
				case 19:
					Console.WriteLine("19세 이용가입니다. 더 이상의 설명은 생략합니다.");
					break;
				default:
					Console.WriteLine("잘못 입력하셨습니다.");
					break;
			}
		}
	}
}
