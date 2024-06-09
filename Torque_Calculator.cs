using System;


namespace Torque_Calculator_
{
    class Program
    {
        static double Torque(double F, double d)
        {
            double result;
            result = F * d;
            return result;

        }
        static void Main(string[] args)
        {
            double F, D, T;

            Console.Write("Enter Force in N = ");
            F = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Distance in meters = ");
            D = Convert.ToDouble(Console.ReadLine());

            T = Torque(F, D);

            Console.Write("The torque to lift the load is  " + T + "  N.m");
            Console.ReadKey();


        }
    }
}
