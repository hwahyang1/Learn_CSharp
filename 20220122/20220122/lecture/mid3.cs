using System;
using System.Collections.Generic;
using System.Text;

class mid3
{
    static void Main9(string[] args)
    {
        int[] arr = new int[10];

        for (int i = 0; i <= 9; i++)
        {
            Console.Clear();
            Console.Write("{0}번 값을 입력하세요: ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.Clear();
        Console.Write("입력된 값은 다음과 같습니다: {");
        for (int i = 0; i <= 9; i++)
        {
            Console.Write((i == 9) ? "{0}" : "{0}, ", arr[i]);
        }

        Console.WriteLine("}");
    }
}
