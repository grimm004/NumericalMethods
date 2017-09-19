using System;

namespace NumericalMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
                Console.WriteLine($"i: { i } FP { SecantMethod.Calculate(i, 0, 1, F) } CoS { ChangeOfSign.Calculate(i, 0, 1, F) } NR { NewtonRaphson.Calculate(i, 1.5, 0.00001, F) } RM { RearrangementMethod.Calculate(i, 0.1, F) }");

            Console.ReadKey();
        }

        static double F(double x)
        {
            return (x * x * x * x * x) - (5 * x) + 1;
        }

        static double Radians(double degrees)
        {
            return degrees / 180 * Math.PI;
        }
    }
}
