using System;

namespace NumericalMethods
{
    class MidpointRule
    {
        public static decimal Calculate(long n, decimal start, decimal end, Func<decimal, decimal> f)
        {
            // Calculate the interval, and initialize values for the total and current position
            decimal interval = (end - start) / n, total = 0, current = start;
            // Loop n times
            for (long i = 0; i < n; i++)
                // Add the evaluated function at the current midpoint to the total
                total += f((current + (current += interval)) / 2);
            // Return the midpoint rule estimate (of the interval multiplied by the total)
            return interval * total;
        }
    }
}
