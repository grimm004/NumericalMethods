using System;

namespace NumericalMethods
{
    class ForwardDifference
    {
        public static double Calculate(double x, double h, Func<double, double> f)
        {
            return (f(x + h) - f(x)) / h;
        }

        public static double Extrapolate(double ei, double ei2)
        {
            return (2 * ei2) - ei;
        }

        public static double Extrapolate(double x, double h, Func<double, double> f)
        {
            return Extrapolate(Calculate(x, h, f), Calculate(x, h / 2d, f));
        }
    }
}
