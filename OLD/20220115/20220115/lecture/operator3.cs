using System;
using System.Collections.Generic;
using System.Text;

class operator3
{
    static void Main3(string[] args)
    {
        // 처리 후 연산
        int count = 0;
        Console.WriteLine(count++);
        Console.WriteLine(count++);
        Console.WriteLine(count++);
        Console.WriteLine(count++);
        Console.WriteLine(count++);
        Console.WriteLine(count++);
        Console.WriteLine(count);

        Console.WriteLine("");

        // 연산 후 처리
        count = 0;
        Console.WriteLine(++count);
        Console.WriteLine(++count);
        Console.WriteLine(++count);
        Console.WriteLine(++count);
        Console.WriteLine(++count);
        Console.WriteLine(++count);
        Console.WriteLine(count);
    }
}
