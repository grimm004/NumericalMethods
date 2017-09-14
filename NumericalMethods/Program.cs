using System;

namespace NumericalMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{ SimpsonsRule.Calculate(1, 2, 4, G) }");

            Console.ReadKey();
        }

        static double G(double x)
        {
            return x * x * x;
        }

        static double R1(double x)
        {
            return ((x * x * x * x * x) + 3) / 5;
        }

        static double R2(double x)
        {
            return Math.Pow((5 * x) - 3, 1/5);
        }

        static double F(double x)
        {
            return (x * x * x * x * x) - (5 * x) + 3;
        }
    }
}
