/*
Here we will learn to create customer method which will be recalled in 
Main method and will save our time.

*/


using System;

namespace Question_4_Cross_Belt_Drive_length_calculation
{
    internal class Program
    {
        static double Binomial(double a, double b)

        {
            double result;
            result = (Math.Pow(a, 2)) + (Math.Pow(b, 2)) + 2 * a * b;
            return result;
        }
        static void Main(string[] args)
        {
            double r1, r2, x, length;

            Console.Write("Enter the radius of Large Pulley =  ");
            r1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the radius of Small Pulley =  ");
            r2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the center distance between pulleys =  ");
            x = Convert.ToDouble(Console.ReadLine());

            length = Math.PI * (r1 + r2) + 2 * x + Binomial(r1, r2) / x;

            Console.Write("The length of Belt = {0}", length);
            Console.ReadKey();
        }
    }
}