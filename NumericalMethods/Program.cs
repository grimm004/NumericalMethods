using System;

namespace NumericalMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output the estimate for a decimal search with 10 iterations
            Console.WriteLine($"n: { 5 }\tEstimate: { DecimalSearch.Calculate(5, -4, -3, F).ToString("0.0000000000") }");
            Console.ReadKey();
        }

        static double F(double x)
        {
            return (x - Math.E) * ((x + Math.PI) * (x + Math.PI));
        }
    }
}
