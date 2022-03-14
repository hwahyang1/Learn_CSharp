using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp._20220312
{
	class Scope
	{
		// 전역 범위 -> 클래스 범위 (클래스 변수, 클래스 메소드)
		static int global_variable1 = 10;
		// 전역 범위 -> 인스턴스 범위 (인스턴스 변수, 인스턴스 메소드)
		int global_variable2 = 10;
		void Global_Method()
		{
			int global_variable2 = 20;
			Console.WriteLine(global_variable2); // => 20 (전역 변수를 덮어버림)
			Console.WriteLine(this.global_variable2); // => 10 (인스턴스 메소드 한정, 전역 변수 호출)
		}

		static void Local_Method()
		{
			// 지역 변수 (다른 메소드와 중복되어도 영향X)
			int local_variable = 30;
		}

		static void Main_20220312_3(string[] args)
		{
			// 지역 변수
			int local_variable = 10;

			// 지역 변수
			int global_variable1 = 20;
			Console.WriteLine(global_variable1); // => 20 (전역 변수를 덮어버림)
			Console.WriteLine(Scope.global_variable1); // => 10 (전역 변수 호출)

			Scope scope = new Scope();
			scope.Global_Method();
		}
	}
}
