//13. Write a program to check whether a given year is a leap year or not.

using System;

namespace Question_13_Leap_Year
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.Write("Enter the Year : ");
            year =Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0)
            {
                Console.Write("{0} is a Leap Year !", year);
            }
            else
                {
                Console.Write("{0} is not a Leap Year !", year);
                }

            Console.ReadKey();

        }
    }
}
