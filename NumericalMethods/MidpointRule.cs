using System;

namespace NumericalMethods
{
    class MidpointRule
    {
        public static decimal Calculate(long n, decimal start, decimal end, Func<decimal, decimal> f)
        {
            decimal interval = (end - start) / n;
            decimal total = 0;
            decimal current = start;
            for (long i = 0; i < n; i++)
                total += f((current + (current += interval)) / 2);
            return interval * total;
        }
    }
}
