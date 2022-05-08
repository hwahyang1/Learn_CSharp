using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp._20220507.상속3
{
	public class Computer
	{
		// 전원 켜기/끄기
		// 주변장치 연결/해제

		bool isPowerOn = false;

		public void TogglePower()
		{
			isPowerOn = !isPowerOn;
			Console.WriteLine("컴퓨터의 전원을 " + (isPowerOn ? "켰습니다." : "껐습니다."));
		}

		public void ConnectDevice(IDevice device)
		{
			if (isPowerOn)
			{
				device.Connected(string.Format("{0}(을)를 이용해주셔서 감사합니다!", device.GetName()));
			}
			else
			{
				Console.WriteLine("전원을 킨 다음 주변 장치를 연결해주세요!");
			}
		}

		public void DisconnectDevice(IDevice device)
		{
			if (isPowerOn)
			{
				Console.WriteLine("전원이 켜져있을 때에는 주변 장치를 제거할 수 없습니다!");
			}
			else
			{
				device.Disconnected(string.Format("{0}(을)를 컴퓨터에서 제거함.", device.GetName()));
			}
		}

		static void Main_20220507_2(string[] args)
		{
			Computer cpu = new Computer();

			KeyBoard kb = new KeyBoard();
			Monitor mn	= new Monitor();

			cpu.TogglePower();

			cpu.ConnectDevice(kb);
			cpu.ConnectDevice(mn);

			cpu.TogglePower();

			cpu.DisconnectDevice(kb);
			cpu.DisconnectDevice(mn);
		}
	}
}
