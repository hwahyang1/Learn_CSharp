using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp._20220507.상속3
{
	public interface IDevice
	{
		/*
		 * [ 인터페이스 특징 ]
		 * 1. 추상 메소드만 작성 가능.
		 *	- 무조건 public으로 작성됨. (접근제한자 생략해도 public으로 작성됨)
		 * 2. 필드의 경우 무조건 클래스 필드로 작성 (인스턴스 필드 X)
		 *	- 무조건 public static이어야 함. (const는 옵션인듯 함.)
		 *	- 프로퍼티는 static 강제가 아닌듯.
		 */

		void Connected(string msg);
		void Disconnected(string msg);
		string GetName();
	}
}
