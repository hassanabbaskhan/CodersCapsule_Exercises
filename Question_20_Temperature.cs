/*
    Question_20_Temperature

20. Write a program to read temperature in centigrade and display a suitable message according
to temperature state below.

Temp < 0 then Freezing weather
Temp 0-10 then Very Cold weather
Temp 10-20 then Cold weather
Temp 20-30 then Normal in Temp
Temp 30-40 then Its Hot
Temp >=40 then Its Very Hot

*/

using System;

namespace Question_20_Temperature
{
    internal class Program
    {
        static void Main(string[] args)

        {
        start:

            {
                int temp;
                Console.Write("Enter the tempareature in Degree Centigrade: ");
                temp = Convert.ToInt32(Console.ReadLine());

                if (temp < 0)
                {
                    Console.WriteLine("Freezing weather");
                }

                else if (temp >= 0 & temp < 10)
                {
                    Console.WriteLine("Very Cold weather");
                }
                else if (temp >= 10 & temp < 20)
                {
                    Console.WriteLine("Cold weather");
                }
                else if (temp >= 20 & temp < 30)
                {
                    Console.WriteLine("Normal in Temp");
                }

                else if (temp >= 30 & temp < 40)
                {
                    Console.WriteLine("It's Hot");
                }
                else
                {
                    Console.WriteLine("It's very hot");

                }

                goto start;
            }

          }
    }
}
