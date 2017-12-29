using System;

namespace NumericalMethods
{
    class SimpsonsRule
    {
        public static decimal Calculate(decimal tn, decimal mn)
        {
            // Calculate and return the weighted average estimate
            return (tn + (2 * mn)) / 3;
        }

        public static decimal GetRatio(decimal sn, decimal s2n, decimal s4n)
        {
            // Calculate the ratio of differences
            return (s4n - s2n) / (s2n - sn);
        }

        public static decimal ExtrapolationToIninity(decimal sn, decimal s2n)
        {
            // Calculate and return the extrapolation to infinity estimate
            return ((s2n - sn) / 15) + s2n;
        }

        public static decimal Calculate(long n, decimal start, decimal end, Func<decimal, decimal> f)
        {
            return Calculate(TrapeziumRule.Calculate(n, start, end, f), MidpointRule.Calculate(n, start, end, f));
        }

        public static decimal GetRatio(long n, decimal start, decimal end, Func<decimal, decimal> f)
        {
            return GetRatio(Calculate(n, start, end, f), Calculate(2 * n, start, end, f), Calculate(4 * n, start, end, f));
        }
    }
}
