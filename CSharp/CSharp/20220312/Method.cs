using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp._20220312
{
	class Method
	{
		static void Main_20220312_1(string[] args)
		{
			Console.Write("아무 숫자나 입력해주세요: ");
			int input = int.Parse(Console.ReadLine());

			Random rand = new Random();
			int random = rand.Next(input);
			//int random = new Random().Next(input);

			Console.WriteLine("0에서 {0} 사이의 숫자 중 {1}(이)가 선택되었습니다.", input, random);
		}
	}
}
