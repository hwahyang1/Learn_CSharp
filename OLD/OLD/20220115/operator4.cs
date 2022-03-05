using System;
using System.Collections.Generic;
using System.Text;

class operator4
{
    static void Main4(string[] args)
    {
        int a = 5;
        int b = 6;
        int c = 5;

        Console.WriteLine("a | {0}", a);
        Console.WriteLine("b | {0}", b);
        Console.WriteLine("c | {0}\n", c);

        Console.WriteLine("a == b | {0}", a == b);
        Console.WriteLine("a == c | {0}\n", a == c);

        Console.WriteLine("a != b | {0}", a != b);
        Console.WriteLine("a != c | {0}\n", a != c);

        Console.WriteLine("a < b | {0}", a < b);
        Console.WriteLine("a > b | {0}", a > b);
        Console.WriteLine("a <= b | {0}", a <= b);
        Console.WriteLine("a >= b | {0}\n", a >= b);

        Console.WriteLine("a < c | {0}", a < c);
        Console.WriteLine("a > c | {0}", a > c);
        Console.WriteLine("a <= c | {0}", a <= c);
        Console.WriteLine("a >= c | {0}\n", a >= c);
    }
}
