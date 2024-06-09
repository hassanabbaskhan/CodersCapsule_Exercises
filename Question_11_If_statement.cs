//11.Write a program to get two integers and check whether they are equal or not.

using System;

namespace Question_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("Enter num1 = ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter num2 = ");
            num2 = Convert.ToInt32(Console.ReadLine());

            //checking conditions

            if (num1 != num2)
            {
                Console.WriteLine("Both entered integers are not same");
            }
            else
            {
                Console.WriteLine("Both the entered integers are same");
            }

            Console.ReadKey();


        }
    }
}
