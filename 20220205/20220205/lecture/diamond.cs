using System;
using System.Collections.Generic;
using System.Text;

class diamond
{
    static void Main6(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;

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

        for (int i = 5; i >= 1; i--)
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

        Console.ForegroundColor = ConsoleColor.White;
    }
}
