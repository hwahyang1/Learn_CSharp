using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp._20220306
{
	class Test
	{
		static void Main_20220306_1(string[] args)
		{
			/*
			 * 1. 아무 숫자나 입력받고 해당 숫자가 2의 제곱수인지 확인해보세요. (예: 1024 = 2의 제곱수입니다.)
			 * 2. 아래의 표를 참고하여 입력된 단어가 거울 단어인지 확인해보세요. (영어만 사용, 대소문자 구분 X)
			 * - b <> d
			 * - i <> i
			 * - l <> l
			 * - m <> m
			 * - o <> o
			 * - p <> q
			 * - s <> z
			 * - u <> u
			 * - v <> v
			 * - w <> w
			 * - x <> x
			 * (예시: pq = 거울단어 / ppq = 일반단어 / poq = 거울단어)
			 */

			Console.Write("수를 입력하세요: ");
			int input1 = int.Parse(Console.ReadLine());
			int input1_dup = input1;
			bool res = true;
			while (true)
			{
				if (input1_dup == 1)
				{
					res = true;
					break;
				}

				if (input1_dup % 2 == 0)
				{
					input1_dup /= 2;
				}
				else
				{
					res = false;
					break;
				}
			}
			Console.WriteLine("{0}은(는) 2의 제곱수{1}", input1, res ? "입니다." : "가 아닙니다.");
			Duplicate.ClearConsoleWhenEntered();

			//char[] convert_dept = new char[] { 'd', 'q', 'z' }; // 변환 대상 검색어 -> 변환하니까 ppq도 대칭문자로 잡힘. 포기
			//char[] convert_ariv = new char[] { 'b', 'p', 's' }; // 변환 목적지
			string[] convert_pair = new string[] { "bd", "db", "pq", "qp", "sz", "zs" }; // 존재 여부 판별
			char[] convert_simple = new char[] { 'i', 'l', 'm', 'o', 'u', 'v', 'w', 'x' }; // 존재 여부 판별

			Console.Write("거울문자 여부를 확인합니다. 영문를 입력하세요: ");
			string input2 = Console.ReadLine();
			string input2_dup = input2.ToLower();

			/*
			 * 존재여부만: i l m o u v w x
			 * 변환: b(d) p(q) s(z) -> 괄호 안을 괄호 밖의 단어로 변환 후 매칭
			 * 
			 * 매칭 ->
			 *		존재 여부만 확인하면 되는 단어: 공백으로 Repl
			 *		대칭 여부를 봐야하는 단어: pq, qp 두개의 경우 고려하여 공백으로 Repl
			 *
			 * 판별 ->
			 *		공백을 제외한 문자가 존재하면 거울문자 X, 존재하지 않으면 거울문자 O
			 */

			foreach (char word in convert_simple)
			{
				input2_dup = input2_dup.Replace(word + "", "");
			}

			/*for (int i = 0; i < convert_dept.Length; i++)
			{
				input2_dup = input2_dup.Replace(convert_dept[i], convert_ariv[i]);
			}*/

			for (int i = 0; i < convert_pair.Length; i++)
			{
				input2_dup = input2_dup.Replace(convert_pair[i], "");
			}

			input2_dup = input2_dup.Replace(" ", "");

			Console.WriteLine("\"{0}\"은(는) 대칭문자{1}", input2, input2_dup.Length == 0 ? "입니다." : "가 아닙니다.");
		}
	}
}
