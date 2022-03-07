using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp._20220306
{
	class _2DimensionalArray
	{
		static void Main_20220306_2(string[] args)
		{
			// 초기화
			int[][] arr1 = new int[5][]; // 바깥만 크기 지정 (안쪽은 대입 할 때 정해짐)

			// 얘는 크기 지정 자유
			arr1[0] = new int[5];
			arr1[1] = new int[3];
			arr1[2] = new int[9];
			arr1[3] = new int[4];
			arr1[4] = new int[2];

			int[,] arr2 = new int[52, 7];

			Console.WriteLine("arr1의 크기: {0} -> {1}", arr1.Length, arr1[0].Length);
			Console.WriteLine("arr2의 크기: {0} -> {1}", arr2.GetLength(0), arr2.GetLength(1)); // arr2는 위의 방법으로 안구해짐. arr1은 얘로도 구해짐
		}
	}
}
