/*
 22. Write a program to display the first 10 natural numbers using while loops.
 
 */

using System;


namespace Question_22_While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;

            while (x <= 10 )
            {
                Console.WriteLine(x);
                x++;

            }
            Console.ReadLine();

        }
    }
}
