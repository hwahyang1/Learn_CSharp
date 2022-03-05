using System;
using System.Collections.Generic;
using System.Text;

class triangle2
{
    static void Main5(string[] args)
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 5 - i; j > 0; j--)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < 2 * i - 1; j++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }
}
