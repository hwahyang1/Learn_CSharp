using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp._20220313
{
	class Scope
	{
		static int maxNumber = 25;
		float pie = 3.14f; // 인스턴스끼리 접근하던가 인스턴스 생성해서 호출해야함 (static이 붙은 메소드)

		static void Main_20220313_1(string[] args)
		{
			Scope scope = new Scope(); // 참조 변수(자료형)

			Console.WriteLine(maxNumber);

			scope.Test();
		}

		void Test()
		{
			float pie = 3.141592f;

			Console.WriteLine(Scope.maxNumber); // static 속성을 가진 변수/메소드만 이렇게 접근 가능
			Console.WriteLine(pie);
			Console.WriteLine(this.pie); // 인스턴스 메소드 -> 전역 인스턴스 변수 접근
		}

		void Test1()
		{
			this.Test(); // 같은 클래스의 인스턴스끼리는 이렇게도 호출 가능
		}

		void Test2(float pie)
		{
			pie = pie; // 이러면 자신을 참조함
			this.pie = pie; // 전역변수에 대입하려면 이렇게
		}
	}
}
