/*
7. Write a program to convert degree to radian.
8. Write a program to convert radian to degree.
9. Write a program to convert kelvin to Fahrenheit.
10. Write a program to convert celsius to Fahrenheit.
*/


using System;
namespace Question_7_to_10_Angle_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Case 1 = Covert Angle Degrees to Radians ");
            Console.WriteLine("Case 2 = Covert Angle Radian to Degrees ");
            Console.WriteLine("Case 3 = Covert Temperature Kelvin to Fahrenheit ");
            Console.WriteLine("Case 4 = Covert Temperature Degrees celcius to Fahrenheit ");

            Console.Write("\nEnter the case # carefully : ");
            int Selection = Convert.ToInt32(Console.ReadLine());

            switch (Selection)
            {
                case 1:  //Question # 7

                    Console.WriteLine("\nCase 1 = Covert Angle Degrees to Radians \n");
                    Console.Write("Enter Angle value in degrees = ");
                    double value = Convert.ToDouble(Console.ReadLine());

                    double result = (Math.PI / 180) * value;
                    Console.WriteLine("{0} degrees =  {1} Radians", value, result);
                    break;

                case 2: //Question # 8
                    Console.WriteLine("\nCase 2 = Covert Angle Radian to Degrees \n");
                    Console.Write("Enter Angle in Radians = ");
                    double value2 = Convert.ToDouble(Console.ReadLine());

                    double result2 = (180 / Math.PI) * value2;
                    Console.WriteLine("{0} Radians = {1} Degrees", value2, result2);
                    break;

                case 3: //Question # 9
                    Console.WriteLine("\nCase 3 = Covert Temperature Kelvin to Fahrenheit \n");
                    Console.Write("Enter temperature in Kelvin = ");
                    double value3 = Convert.ToDouble(Console.ReadLine());

                    double result3 = 1.8 * (value3 - 273) + 32;
                    Console.WriteLine("{0} Kelvin  =  {1} Fahrenheit",value3,result3);
                    break;

                case 4: //Question # 10
                    Console.WriteLine("\nCase 4 = Covert Temperature Degrees celcius to Fahrenheit \n");
                    Console.Write("Enter temperature in Degree celcius = ");
                    double value4 = Convert.ToDouble(Console.ReadLine());

                    double result4 = ((9 / 5) * value4) - 32;
                    Console.WriteLine("{0} degree celcius  = {1} degree Fahrenheit ", value4 , result4);
                    break;

            }
            Console.ReadKey();
        }
    }
}
