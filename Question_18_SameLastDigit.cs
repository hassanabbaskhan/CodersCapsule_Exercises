// 18. Write a program to check if two given non-negative integers have the same last digit.

using System;
namespace CheckLastDigit
{
    class program
    {
        static void Main(string[] args)
        {



        start:
            {
                /*
                here we will use the remainder method, we will divide the numbers by 10, and know if their remainders are same.
                
                */

                int a, b;
                bool lastDigit;  //boolean data type


                Console.WriteLine("Enter number a:  ");
                a = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter number b:  ");
                b = Convert.ToInt32(Console.ReadLine());

                lastDigit = SameLastDigit(a, b); //calling function


               if (lastDigit)
                {
                    Console.WriteLine("Both the numbers' last digit is same");

                }

                else
                {
                    Console.WriteLine("Both the numbers' last digit is not same");
                }
                Console.ReadKey();
                Console.Write("\n");

            }
            //using a boolean function

            bool SameLastDigit(int num1, int num2)  //static is not the correct
            {
                int x = num1 % 10; //x will be the remainder
                int y = num2 % 10; //y will be the remainder

                return x == y; //if it's true, as it's boolean data type
            }
            goto start;
        }
    }
}
