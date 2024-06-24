/*
 Question_20_Temperature

21. Write a program to read any Month Number in integer and display Month name in the word. 
 
 */


using System;


namespace Question_21_Month
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start:
            {
                int month;

                Console.Write("Enter Month number : ");
                month=Convert.ToInt32(Console.ReadLine());

                switch (month)
                {
                    case 1:
                        Console.WriteLine("Januarty");
                        break;

                    case 2:
                        Console.WriteLine("February");
                        break;
                        
                    case 3:
                        Console.WriteLine("March");
                        break;

                    case 4:
                        Console.WriteLine("April");
                        break;

                    case 5:
                        Console.WriteLine("May");
                        break;

                    case 6:
                        Console.WriteLine("June");
                        break;

                    case 7:
                        Console.WriteLine("July");
                        break;

                    case 8:
                        Console.WriteLine("August");
                        break;

                    case 9:
                        Console.WriteLine("September");
                        break;

                    case 10:
                        Console.WriteLine("October");
                        break;

                    case 11:
                        Console.WriteLine("November");
                        break;

                    case 12:
                        Console.WriteLine("December");
                        break;

                }

            }
            goto start;

        }
    }
}
