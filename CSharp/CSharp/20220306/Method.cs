using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp._20220306
{
	class Method
	{
		/*
		 * 접근제한자: 생략됨 (internal)
		 * static: 존재
		 * 자료형: void (반환 X)
		 * 이름: Main
		 * 매개변수: 1개
		 *	- string[] -> args
		 */
		/*internal*/ static void Main_20220306_3(string[] args)
		{
			// 호출하려는 메소드에 static 속성 없는경우 -> 클래스 이름 가지고 instance 생성하여 호출
			Method instance = new Method();
			instance.Hello1();

			new Method().Hello1(); // 이것도 되긴 함

			// 호출하려는 메소드에 static 속성 있는경우 -> 메소드 호출
			Hello2();
		}

		/*
		 * 접근제한자: public
		 * static: 존재하지 않음
		 * 자료형: void (반환 X)
		 * 이름: Hello
		 * 매개변수: 0개
		 */
		public void Hello1()
		{
			Console.WriteLine("Hello, World!");
		}

		/*
		 * 접근제한자: public
		 * static: 존재
		 * 자료형: void (반환 X)
		 * 이름: Hello
		 * 매개변수: 0개
		 */
		public static void Hello2()
		{
			Console.WriteLine("Hello, World!");
		}
	}
}
