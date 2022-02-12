using System;
using System.Collections.Generic;
using System.Text;

class forfor
{
    static void Main1(string[] args)
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("I: {0} | J: {1}", i, j);
            }
            Console.WriteLine("\n");
        }
    }
}
