using System;

/*
 * lI 분간 안되면:
 * 도구 -> 옵션 -> 환경 -> 글꼴 및 색 -> Consolas로 폰트 변경
 */

namespace CSharp._20220212
{
	class HelloWorld
	{
		static void Main_20220212_1(string[] args)
		{
			Console.WriteLine("Hello World!");
			Console.WriteLine("{0}년 {1:d2}월 {2}일", 2020, 02, 12);
			Console.WriteLine("{0:n0}", 1000000000); // 자동 쉼표 (0은 소숫점 자리)
			Console.WriteLine("{0:d}", 10); // 10진수 변환
			Console.WriteLine("{0:x}", 10); // 16진수 변환
		}
	}
}
