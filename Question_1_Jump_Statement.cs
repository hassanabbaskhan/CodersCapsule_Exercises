//1. Write a program to get 3 values from user and print sum of its square value.

using System;


namespace Question_1_Jump_Statement
{
    class Program
    {
      
        static void Main(string[] args)
        {
            start:
            {
                double a, b, c;

                Console.Write("\nEnter num1 = ");
                a= Convert.ToDouble(Console.ReadLine());


                Console.Write("Enter num2 = ");
                b = Convert.ToDouble(Console.ReadLine());


                Console.Write("Enter num3 = ");
                c = Convert.ToDouble(Console.ReadLine());

                double sum = Math.Pow(a,2) + Math.Pow(b,2) + Math.Pow(c,2);
                Console.WriteLine("The sum of squares of {0}, {1}, {2} is {3}", a, b, c, sum);

                Console.ReadKey();
                           
            }
            goto start;

        }

      

    }
}
