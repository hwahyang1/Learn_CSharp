using System;
using System.Collections.Generic;
using System.Text;

class infinity
{
	static void Main7(string[] args)
	{
		/*for (; ; )
		{
			count++;
			Console.WriteLine(count);
		}*/
		while (true)
		{
			switch (new Random().Next(1, 5))
			{
				case 1:
					Console.BackgroundColor = ConsoleColor.Green;
					Console.ForegroundColor = ConsoleColor.Red;
					break;
				case 2:
					Console.BackgroundColor = ConsoleColor.Red;
					Console.ForegroundColor = ConsoleColor.Green;
					break;
				case 3:
					Console.BackgroundColor = ConsoleColor.Cyan;
					Console.ForegroundColor = ConsoleColor.Yellow;
					break;
				case 4:
					Console.BackgroundColor = ConsoleColor.Yellow;
					Console.ForegroundColor = ConsoleColor.Cyan;
					break;
				case 5:
					Console.BackgroundColor = ConsoleColor.Blue;
					Console.ForegroundColor = ConsoleColor.White;
					break;
				case 6:
					Console.BackgroundColor = ConsoleColor.White;
					Console.ForegroundColor = ConsoleColor.Blue;
					break;
			}
			Console.Write(new Random().Next(100000, 1000000));
		}
	}
}