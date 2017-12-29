using System;

namespace NumericalMethods
{
    class TrapeziumRule
    {
        public static decimal Calculate(long n, decimal start, decimal end, Func<decimal, decimal> f)
        {
            // Calculate the interval, initialize the total and current values
            decimal interval = (end - start) / n, total = 0, current = start;
            // Sum up the evaluated function values between the start and end x-values
            for (long i = 0; i < n - 1; i++)
                total += f((current += interval));
            // Calculate and return the estimate using the trapezium rule formula
            return (interval * (f(start) + f(end) + (2 * total))) / 2;
        }

        public static decimal Calculate(decimal mn, decimal tn)
        {
            // Return the estimate for T<2n> based on T<n> and M<n>
            return (mn + tn) / 2;
        }
    }
}
