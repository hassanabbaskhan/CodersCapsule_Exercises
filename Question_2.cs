//2. Write a program to get 3 values from user and print sum of its cube value.

using System;

namespace Addition_of_valueCubes
{
 class addition
    {
        static void Main()
        {
            double num1, num2, num3, sum;

            Console.Write("Enter num1 = ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter num2 = ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter num3 = ");
            num3 = Convert.ToDouble(Console.ReadLine());

            sum = Math.Pow(num1, 3) + Math.Pow(num2, 3) + Math.Pow(num3, 3); //Math.Pow function executes only if datatype is double

            Console.Write("The sum of cubes of {0}, {1}, {2} is {3}", num1, num2, num3, sum);
            Console.ReadKey();

        }
    }
}
