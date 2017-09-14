using System;

namespace NumericalMethods
{
    class MidpointRule
    {
        public static double Calculate(long n, double start, double end, Func<double, double> f)
        {
            double interval = (end - start) / n;
            double total = 0;
            double current = start;
            for (long i = 0; i < n; i++)
                total += f((current + (current += interval)) / 2);
            return interval * total;
        }
    }
}
