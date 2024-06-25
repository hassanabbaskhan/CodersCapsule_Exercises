
/*
23.  Write a program to display the first 10 even numbers using while, for and do while loops.
 
 */

using System;

namespace Question_22_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;

            for ( x = 2; x <= 20; x = x + 2)

            {
                Console.WriteLine(x);
            }
            Console.ReadLine();

        }
    }
}
