using System;

namespace NumericalMethods
{
    class SecantMethod
    {
        public static double Calculate(int n, double x0, double x1, Func<double, double> f)
        {
            if (n == 0) return Secant(x0, x1, f);
            return Calculate(n - 1, x1, Secant(x0, x1, f), f);
        }

        protected static double Secant(double x0, double x1, Func<double, double> f)
        {
            return ((x0 * f(x1)) - (x1 * f(x0))) / (f(x1) - f(x0));
        }

        protected static double Line(double x, double m, double c)
        {
            return (m * x) + c;
        }
    }
}
