//14. Write a program to find the largest of three numbers.

using System;

namespace Question_14
{
    class Program
    {
        static void Main(string[] args)
        {
        start:

            {
                int num1, num2, num3;

                Console.Write("Enter num1 = ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter num2 = ");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter num3 = ");
                num3 = Convert.ToInt32(Console.ReadLine());


                if (num1 > num2 && num1 > num3)
                {
                    Console.Write("{0} is the largest number !", num1);
                }

                else if (num2 > num1 && num2 > num3)
                {
                    Console.Write("{0} is the largest number !", num2);
                }

                else if (num1 == num2 || num1 == num3 || num2 == num3)
                {
                    Console.Write("Enter only UNIQUE numbers");
                }

                else
                {
                    Console.Write("{0} is the largest number",num3);
                }
                
                //Console.ReadKey();
                Console.Write('\n');

                goto start;
            }

        }
    }
}
