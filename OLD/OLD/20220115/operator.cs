using System;
using System.Collections.Generic;
using System.Text;

class @operator
{
    static void Main1(string[] args)
    {
        int a = 1415;
        int b = 416;
        int c = 945;
        int value = 0;

        Console.WriteLine("a | {0}", a);
        Console.WriteLine("b | {0}", b);
        Console.WriteLine("c | {0}", c);
        Console.WriteLine("value | {0}\n", value);

        /* 대입 */
        value = a;
        Console.WriteLine("value | {0}\n", value);

        /* 사칙연산 */
        value = a + b;
        Console.WriteLine("a + b | {0}", value);
        value = a - b;
        Console.WriteLine("a - b | {0}", value);
        value = a * b;
        Console.WriteLine("a * b | {0}", value);
        value = a / b;
        Console.WriteLine("a / b | {0}", value);
        value = a % b;
        Console.WriteLine("a % b | {0}\n", value); // 나머지

        value = (a + b) * c;
        Console.WriteLine("(a + b) * c | {0}\n", value);
    }
}
