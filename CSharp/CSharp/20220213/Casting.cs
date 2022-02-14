using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp._20220213
{
	class Casting
	{
		static void Main_20220213_3(string[] args)
		{
			/* 묵시적 형 변환 (작은거 -> 큰거) */
			short _short = 10000;
			int _int1 = _short;
			Console.WriteLine("_short: {0}", _short);
			Console.WriteLine("_int: {0}\n", _int1);

			/* 명시적 형 변환 (큰거 -> 작은거 OR 실수 -> 정수 (내용의 손실이 발생 될 경우)) */
			double _double = 3.14159265358;
			int _int2 = (int)_double;
			Console.WriteLine("_double: {0}", _double);
			Console.WriteLine("_int: {0:n0}\n", _int2);

			long _long = 9220000000000000000L;
			int _int3 = (int)_long;
			Console.WriteLine("_long: {0:n0}", _long);
			Console.WriteLine("_int: {0:n0}\n", _int3);
		}
	}
}
