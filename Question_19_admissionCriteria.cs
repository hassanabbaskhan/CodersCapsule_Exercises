/*

19. Write a program to find the eligibility of admission for a 
professional course based on the following criteria.

Marks in Maths >=85
Marks in Phy >=75
Marks in Chem>=70
Total in all three subject >=230

*/

using System;
namespace elegibility
{
    class program
    {
        static void Main(string[] args)
        {

        start:
            {
                int Maths, Phy, Chem;

                Console.Write("Enter the marks of Maths: ");
                Maths = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the marks of Phy: ");
                Phy = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the marks of Chem: ");
                Chem = Convert.ToInt32(Console.ReadLine());


                if (Maths >= 85 & Phy >= 75 & Chem >= 70)
                {
                    Console.WriteLine("Eligible for Admission");
                }

                else
                {
                    Console.WriteLine("Not Eligible for Admission");
                }

                Console.ReadKey();
                Console.Write("\n");

            }
            //using a boolean function

            goto start;
        }

    }
}