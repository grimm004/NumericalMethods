using System;

namespace NumericalMethods
{
    class NewtonRaphson
    {
        public static double Calculate(int n, double x0, Func<double, double> f, Func<double, double> fPrime)
        {
            // If the remaining iterations is equal to zero, return the inputted value of x0
            if (n == 0) return x0;
            // Calculate x1 by recursively calling this function again
            double x1 = Calculate(n - 1, x0, f, fPrime);
            Console.WriteLine($"x<{ n - 1 }>:\t{ x1 }");
            // Return the result of the Newton-Raphson equation on this new value of x
            return (x1 - (f(x1) / fPrime(x1)));
        }

        public static double Calculate(int n, double x0, double h, Func<double, double> f)
        {
            // If the remaining iterations is equal to zero, return the inputted value of x0
            if (n == 0) return x0;
            // Calculate x1 by recursively calling this function again
            double x1 = Calculate(n - 1, x0, h, f);
            Console.WriteLine($"x<{ n - 1 }>:\t{ x1 }");
            // Return the result of the Newton-Raphson equation on this new value of x using the CentralDifference method to estimate the gradient
            return (x1 - (f(x1) / CentralDifference.Calculate(x1, h, f)));
        }

        public static double Calculate(int maxIterations, double x0, Func<double, double> f, Func<double, double> fPrime, double tolerance = 10e-7, double epsilon = 10e-14)
        {
            for (int i = 0; i < maxIterations; i++)
            {
                double y = f(x0);
                double yPrime = fPrime(x0);

                if (Math.Abs(yPrime) < epsilon) break;

                double x1 = x0 - (y / yPrime);

                Console.WriteLine($"x<{ i }>:\t{ x1 }");
                
                if (Math.Abs(x1 - x0) < tolerance * Math.Abs(x1))
                { Console.WriteLine("Solution found"); break; }

                x0 = x1;
            }

            return x0;
        }
    }
}
