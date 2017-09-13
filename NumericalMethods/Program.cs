using System;

namespace NumericalMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5000;
            for (double i = -2; i < 2; i++) Console.WriteLine($"n: { n }\tstart: { i }\tNewton Raphson Method: { NewtonRaphson.Calculate(n, i, 0.0001d, F).ToString("0.000000000000000") }");
            Console.ReadKey();
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

        static double Fp(double x)
        {
            return (5 * (x * x * x * x)) - 5;
        }
    }
}
