using System;

namespace NumericalMethods
{
    class TrapeziumRule
    {
        public static decimal Calculate(long n, decimal start, decimal end, Func<decimal, decimal> f)
        {
            decimal interval = (end - start) / n;
            decimal total = 0;
            decimal current = start;
            for (long i = 0; i < n - 1; i++)
                total += f((current += interval));
            return (interval * (f(start) + f(end) + (2 * total))) / 2;
        }

        public static decimal Calculate(decimal mn, decimal tn)
        {
            return (mn + tn) / 2;
        }
    }
}
