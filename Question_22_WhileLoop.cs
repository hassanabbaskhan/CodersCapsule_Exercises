
/*
22. Write a program to display the first 10 natural numbers using while, for and do while loops.

 
 */

using System;

namespace Question_22_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2;


            while (x <= 20)
            {
                Console.WriteLine(x);
                x=x+2;
            }
            Console.ReadKey();
        }
    }
}
