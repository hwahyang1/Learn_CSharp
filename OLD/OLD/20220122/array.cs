using System;
using System.Collections.Generic;
using System.Text;

class array
{
	static void Main8(string[] args)
	{
		int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
		//int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
		//int[] arr; arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

		/*foreach (int now in arr) // 느림, 꼬임 ==> 망함 (짧은 배열에는 편리)
		{
			Console.WriteLine(now);
		}*/

		arr[5] = 16320;

		for (int i = 0; i < arr.Length; i++)
		{
			Console.WriteLine(arr[i]);
		}
	}
}
