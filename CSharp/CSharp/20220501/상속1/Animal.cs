using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp._20220501.상속1
{
	/*
	 * [ 동물 ]
	 * - 개, 고양이
	 * - 속성: 성별, 나이, 이름
	 * - 행동: 먹기, 잠자기, 짖기
	 * 
	 * [ 접근 제한자 ]
	 * - protected: 상속 관계에서만 사용 가능하도록 설정 + 같은 폴더면 가능하긴 함
	 * 
	 * [ 가상(Virtual) 메소드 ]
	 * 자식이 Override 가능, 하지만 부모 자체로(Override 없이)도 실행 가능
	 * => 공통된 코드를 부모에 넣고, 개별 코드를 자식에 넣어서 "부모 메소드 호출 -> 자식 코드 실행" 구조로 운영 가능
	 */

	public class Animal
	{
		// Instance Field
		protected string name;
		protected string gender;
		protected int age;

		// Constructor
		public Animal(string name, string gender, int age)
		{
			this.name = name;
			this.gender = gender;
			this.age = age;
		}

		// Method
		public void Eat(string foodName)
		{
			Console.WriteLine("{0}(이)가 {1}(을)를 맛있게 먹고 있습니다!", name, foodName);
		}

		public virtual void Sleep()
		{
			Console.WriteLine("{0}(이)가 세상 모르게 자고 있습니다...", name);
		}
	}
}
