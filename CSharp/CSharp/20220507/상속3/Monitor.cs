using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp._20220507.상속3
{
	public class Monitor : IOutputDevice
	{
		public void Connected(string msg)
		{
			Console.WriteLine("모니터 연결됨: " + msg);
		}

		public void Disconnected(string msg)
		{
			Console.WriteLine("모니터 연결해제됨: " + msg);
		}

		public string GetName()
		{
			return "모니터";
		}
	}
}
