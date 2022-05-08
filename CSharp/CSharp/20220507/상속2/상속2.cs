using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp._20220507.상속2
{
	public class 상속2
	{
		static void Main_20220507_1(string[] args)
		{
			/*
			 * [ 업 캐스팅 ]
			 * 위로 형태를 바꾸는 것 (자식이 부모의 형태로 바꾸는 것)
			 * 
			 * = 자식의 정체성을 잃게 만드는 행위.
			 *	자식만 가지고 있는 특별한 메소드를 사용할 수 없게 됨.
			 * 
			 * 자식 클래스들에 공통된 메소드를 한번에 호출하고 싶을 때 사용
			 * 
			 * [ 다운 캐스팅 ]
			 * 아래로 형태를 바꾸는 것 (부모가 자식의 형태로 바꾸는 것)
			 * 선행조건 = 부모의 형태로 만들어진 인스턴스는 무조건 자식 인스턴스여야 함.
			 * 
			 * = 정체성을 잃은 자식 형태의 인스턴스에게 다시 정체성을 찾아주는 행위.
			 *	공통되지 않은 자식 클래스만의 메소드를 실행하고 싶을 때 사용
			 * 
			 * [ 키워드 ]
			 * is = 부모 형태의 인스턴스가 해당 자식 형태로 다운 캐스팅이 가능한지에 대한 여부
			 * as = 알아서 다운 캐스팅 (다운 캐스팅 공통인데, 불가한 경우 변수값에 null 때려버림. 아니면 InvalidCastException 터지거나)
			 */

			Animal[] animals = new Animal[4];
			
			for (int i = 0; i < animals.Length; i++)
			{
				Console.Write("이름, 성별, 나이를 입력하세요 (띄어쓰기로 구분): ");
				string[] input = Console.ReadLine().Split(" ");

				if ((i + 1) % 2 == 0)
				{
					// 자동 업 캐스팅
					animals[i] = new Dog(input[0], input[1], int.Parse(input[2]));
				}
				else
				{
					animals[i] = new GoldFish(input[0], input[1], int.Parse(input[2]));
				}
			}

			Console.WriteLine();

			for (int i = 0; i < animals.Length; i++)
			{
				//animals[i].Sleep();
				if (animals[i] is Dog) // Dog로 다운캐스팅 가능 여부
				{
					// 다운캐스팅 (형 변환과 코드 구조는 동일)
					Dog dog = (Dog)animals[i];
					dog.Bark();
				}
				else // GoldFish겠지 뭐.. (Animal은 자신의 인스턴스 생성 불가)
				{
					GoldFish goldFish = (GoldFish)animals[i];
					goldFish.Puff();
				}
			}
		}
	}
}
