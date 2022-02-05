using System;
using System.Collections.Generic;
using System.Text;

class gugudan
{
    static void Main2(string[] args)
    {
        for (int i = 2; i < 10; i++)
        {
            for (int j = 1; j < 10; j++)
            {
                Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
            }
            Console.WriteLine("");
        }
    }
}
