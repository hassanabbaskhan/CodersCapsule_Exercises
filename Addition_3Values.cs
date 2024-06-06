//Ask user to input 3 numbers, and find its sum..

﻿using System;


namespace Addition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;

            Console.Write("Enter the num 1  = ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the num 2  = ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the num 3  = ");
            num3 = Convert.ToInt32(Console.ReadLine());


            int sum = num1 + num2 + num3;

            //text formatting is being used here easy to understand.

            Console.WriteLine("Sum of {0},{1} and {2} equals {3}", num1, num2, num3,sum);
            Console.ReadKey();

        }
    }
}
