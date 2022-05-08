using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp._20220507.상속2
{
	/*
	 * [ 추상 클래스 ]
	 * 추상 메소드를 담을 수 있는 클래스 (일반 메소드도 담을 수 있음)
	 * 추상 메소드에 대한 처리가 불가능해져서 부모는 인스턴스화 불가능
	 * 
	 * [ 생성자 ]
	 * 추상화 불가능
	 * 
	 * [ 추상 메소드 ]
	 * 메소드 선언만 하고 내부 구현 X (사용 불가능)
	 *	=> 내부 구현은? -> 강제로 자식이 구현
	 */
	public abstract class Animal
	{
		protected string name;
		protected string gender;
		protected int age;

		public Animal(string name, string gender, int age)
		{
			this.name = name;
			this.gender = gender;
			this.age = age;
		}
		
		public abstract void Eat(string food);
		public abstract void Sleep();
	}
}
