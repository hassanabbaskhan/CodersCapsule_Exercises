//12. Write a program to check whether a given number is positive or negative.

using System;

namespace Question_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;

            Console.Write("Enter a number = ");
            num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 < 0)
            {
                Console.WriteLine("{0} is a negative number", num1);
            }

            else if (num1 > 0)
            {
                Console.WriteLine("{0} is a positive number", num1);

            }

            else
            {
                Console.WriteLine("{0} is a whole number", num1);
            }
            Console.ReadKey();
        }
    } 
}
