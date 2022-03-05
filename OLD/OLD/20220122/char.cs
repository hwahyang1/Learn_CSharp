using System;
using System.Collections.Generic;
using System.Text;

class @char
{
	static void Main11(string[] args)
	{
		char[] arr = { 'c', 'h', 'a', 'r' };

		string arrSum = new string(arr);

		foreach (char now in arr)
			Console.Write(now);

		Console.WriteLine("");
		Console.WriteLine(arrSum);
	}
}
