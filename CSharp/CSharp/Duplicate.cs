using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
	class Duplicate
	{
		public static void ClearConsoleWhenEntered()
		{
			Console.Write("\n계속하려면 아무 키나 누르세요...");
			Console.ReadKey();
			Console.Clear();
		}

		public static void PrintArray(int[] arr, bool changeLine = true)
		{
			Console.Write("{ ");
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i]);
				if (i < arr.Length - 1)
					Console.Write(", ");
			}
			Console.Write(" }");

			if (changeLine)
				Console.Write("\n");
		}
		public static void PrintArray(string[] arr, bool changeLine = true)
		{
			Console.Write("{ ");
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i]);
				if (i < arr.Length - 1)
					Console.Write(", ");
			}
			Console.Write(" }");

			if (changeLine)
				Console.Write("\n");
		}
	}
}
