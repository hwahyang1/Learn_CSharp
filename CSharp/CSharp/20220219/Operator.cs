using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp._20220219
{
	class Operator
	{
		static void Main_20220219_1(string[] args)
		{
			/* 대입 연산자 (=) */
			int a = 10;
			int b = 5;
			Console.WriteLine("a: {0}\nb: {1}\n", a, b);

			/* 산술 연산자 (+ - * / %) */
			Console.WriteLine("a + b: {0}", a + b);
			Console.WriteLine("a - b: {0}", a - b);
			Console.WriteLine("a * b: {0}", a * b);
			Console.WriteLine("a / b: {0}", a / b);
			Console.WriteLine("a % b: {0}\n", a % b);

			/* 단항 연산자 -> 전위/후위 증감 연산자 (++ --) */
			Console.WriteLine("a: {0}", a);
			Console.WriteLine("++a: {0}", ++a);
			Console.WriteLine("--a: {0}", --a);
			Console.WriteLine("a: {0}", a);
			Console.WriteLine("a++: {0}", a++);
			Console.WriteLine("a--: {0}", a--);
			Console.WriteLine("a: {0}\n", a);

			/* 비교 연산자 (== != > < >= <=) */
			Console.WriteLine("a == b: {0}", a == b);
			Console.WriteLine("a != b: {0}", a != b);
			Console.WriteLine("a > b: {0}", a > b);
			Console.WriteLine("a < b: {0}\n", a < b);

			/* 삼항 연산자 (Condition?True:False) */
			int percent = (a > b) ? 100 : 50;
			Console.WriteLine("percent: {0}\n", percent);

			/* 논리 연산자 (& | ^ !) */
			/*
			 * &: AND
			 * |: OR
			 * ^: XOR
			 * !: NOT
			 */

			/* 조건부 논리 연산자 (&& ||) */
			/*
			 * 모든 조건을 계산하는 논리 연산자와 달리 필요 없는 계산을 안함
			 * &&: AND
			 * ||: OR
			 */

			/* 비트 연산자 (~ & | ^) */
			/*
			 * 2진수로 변환하여 연산 (반환값도 2진수)
			 * ~: 2의 보수
			 * &: AND
			 * |: OR
			 * ^: XOR
			 */

			/* 비트 시프트 연산자 (<< >>) */

			/* 복합 대입/할당 연산자 (+= -= *= /= %= &= |= ^= <<= >>=) */
			Console.WriteLine("a += b: {0}\na: {1}\nb: {2}", a += b, a, b);
			Console.WriteLine("a -= b: {0}\na: {1}\nb: {2}", a -= b, a, b);
			Console.WriteLine("a *= b: {0}\na: {1}\nb: {2}", a *= b, a, b);
			Console.WriteLine("a /= b: {0}\na: {1}\nb: {2}", a /= b, a, b);
			Console.WriteLine("a %= b: {0}\na: {1}\nb: {2}", a %= b, a, b);

			/* 그 외 */
		}
	}
}
