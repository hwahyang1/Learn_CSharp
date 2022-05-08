using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp._20220507.상속3
{
	public class KeyBoard : IInputDevice
	{
		public void Connected(string msg)
		{
			Console.WriteLine("키보드 연결됨: " + msg);
		}

		public void Disconnected(string msg)
		{
			Console.WriteLine("키보드 연결해제됨: " + msg);
		}

		public string GetName()
		{
			return "키보드";
		}
	}
}
