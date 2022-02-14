using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp._20220213
{
	class Test
	{
		static void Main_20220213_4(string[] args)
		{
			long number = 10000000000000000L;
			Console.WriteLine("number: {0}\n", number);

			Console.Write("문자를 입력하세요: ");
			string input = Console.ReadLine();
			Console.WriteLine("입력하신 문자는: {0}\n", input);

			float pie = 3.141592f;
			int converted = (int)pie;
			float asdf = converted;
			Console.WriteLine("pie: {0}", pie);
			Console.WriteLine("converted: {0}", converted);
			Console.WriteLine("asdf: {0}", asdf);
		}
	}
}
