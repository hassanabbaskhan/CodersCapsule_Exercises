//Swapping 2 Numbers

using System;

namespace Question_6_Swapping
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, temp; //temp variable to store one number for output

            Console.WriteLine("Numbers before swapping ! \n"); // output with one line spacing

            Console.Write("Enter 1st number = ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter 2nd Number = ");
            num2 = Convert.ToDouble(Console.ReadLine());

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("\n\nNumbers after swapping \n"); // output with two lines spacing
            Console.WriteLine("number 1 : " +  num1);
            Console.WriteLine("number 2 : " +  num2);

            Console.ReadKey();



        }
    }
}
