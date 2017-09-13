using System;

namespace NumericalMethods
{
    class CentralDifference
    {
        public static double Calculate(double x, double h, Func<double, double> f)
        {
            return (f(x + h) - f(x - h)) / (2 * h);
        }
    }
}
