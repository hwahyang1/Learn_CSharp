using System;
using System.Collections.Generic;
using System.Text;

class triangle
{
    static void Main4(string[] args)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5-i; j++)
            {
                Console.Write("* ");
            }
            Console.Write("\n");
        }
    }
}
