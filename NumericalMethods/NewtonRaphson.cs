using System;

namespace NumericalMethods
{
    class NewtonRaphson
    {
        public static double Calculate(int n, double x, double h, Func<double, double> f)
        {
            if (n == 0) return x;
            double newX = Calculate(n - 1, x, h, f);
            return (newX - (f(newX) / CentralDifference.Calculate(newX, h, f)));
        }

        public static double Calculate(int n, double x, double h, Func<double, double> f, Func<double, double> fp)
        {
            if (n == 0) return x;
            double newX = Calculate(n - 1, x, h, f);
            return (newX - (f(newX) / fp(newX)));
        }
    }
}
