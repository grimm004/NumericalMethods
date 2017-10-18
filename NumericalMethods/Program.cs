using System;

namespace NumericalMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 20;
            Console.WriteLine($"iterations: { n } { RearrangementMethod.Calculate(n, -1.5, G) }");

            Console.ReadKey();
        }

        static double F(double x)
        {
            //return (x * x * x) - (4 * x * x) + (2 * x) + 2;
            return (.5f * x * x * x) - (x * x) - (2.5f * x) + Math.E;
        }

        static double G(double x)
        {
            return (2f * ((.5f * x * x * x) - (x * x) + Math.E)) / 5f;
        }
    }
}
