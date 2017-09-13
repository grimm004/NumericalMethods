using System;

namespace NumericalMethods
{
    class ChangeOfSign
    {
        public static double Calculate(double n, double start, double end, Func<double, double> function)
        {
            double estimate = 0;
            for (double i = 1; i - 1 < n; i++)
            {
                bool negitive = function(start) < 0;
                for (double x = start; x < end; x += 1 / Math.Pow(10, i))
                {
                    double fx = function(x);
                    if (fx == 0) return x;
                    else if (fx < 0 != negitive)
                    {
                        estimate = x;
                        start = x - (1 / Math.Pow(10, i));
                        end = x;
                        break;
                    }
                }
            }
            return estimate;
        }
    }
}
