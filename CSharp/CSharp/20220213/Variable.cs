using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp._20220213
{
	class Variable
	{
		static void Main_20220213_2(string[] args)
		{
			bool _bool = true;
			_bool = false;
			Console.WriteLine("_bool: {0}", _bool);

			const byte _byte = 255;
			Console.WriteLine("_byte: {0}", _byte);

			short _short = 32000;
			Console.WriteLine("_short: {0}", _short);

			int _int = 210000000; // 기본형
			Console.WriteLine("_int: {0:n0}", _int);

			long _long = 9220000000000000000L;
			Console.WriteLine("_long: {0:n0}", _long);

			float _float = 3.14159265358f; // double보다 속도는 높고 정확도는 떨어짐, Unity에서 많이 사용
			Console.WriteLine("_float: {0}", _float);

			double _double = 3.14159265358; // 기본형
			Console.WriteLine("_double: {0}", _double);

			/*
			 * 생략된 내용: ushort, uint, ulong
			 * Unsigned, 양수만 존재
			 */

			char _char = 'A';
			Console.WriteLine("_char: {0}", _char);

			string _string = "asdf";
			Console.WriteLine("_string: {0}", _string);

			var _var = 10; // 초기화 하면 자료형 *고정됨*
			Console.WriteLine("_var: {0}", _var);
		}
	}
}
