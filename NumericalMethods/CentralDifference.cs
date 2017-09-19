using System;

namespace NumericalMethods
{
    class CentralDifference
    {
        public static double Calculate(double x, double h, Func<double, double> f)
        {
            return (f(x + h) - f(x - h)) / (2 * h);
        }

        public static double Extrapolate(double ei, double ei2)
        {
            return ei2 + ((ei2 - ei) / 3);
        }

        public static double Extrapolate(double x, double h, Func<double, double> f)
        {
            return Extrapolate(Calculate(x, h, f), Calculate(x, h / 2d, f));
        }
    }
}
