using System;

namespace NumericalMethods
{
    class TrapeziumRule
    {
        public static double Calculate(long n, double start, double end, Func<double, double> f)
        {
            double interval = (end - start) / n;
            double total = 0;
            double current = start;
            for (long i = 0; i < n - 1; i++)
                total += f((current += interval));
            return (interval * (f(start) + f(end) + (2 * total))) / 2;
        }

        public static double Calculate(double mn, double tn)
        {
            return (mn + tn) / 2;
        }
    }
}
