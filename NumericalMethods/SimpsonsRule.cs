using System;

namespace NumericalMethods
{
    class SimpsonsRule
    {
        public static decimal Calculate(decimal tn, decimal mn)
        {
            return (tn + (2 * mn)) / 3;
        }

        public static decimal Calculate(long n, decimal start, decimal end, Func<decimal, decimal> f)
        {
            decimal tn = TrapeziumRule.Calculate(n, start, end, f);
            decimal mn = MidpointRule.Calculate(n, start, end, f);

            return (tn + (2 * mn)) / 3;
        }

        public static decimal GetRatio(long n, decimal start, decimal end, Func<decimal, decimal> f)
        {
            decimal sn = Calculate(n, start, end, f);
            decimal s2n = Calculate(2 * n, start, end, f);
            decimal s4n = Calculate(4 * n, start, end, f);
            return (s4n - s2n) / (s2n - sn);
        }

        public static decimal ExtrapolationToIninity(decimal sn, decimal s2n)
        {
            return ((s2n - sn) / 15) + s2n;
        }

        public static decimal ExtrapolationToIninity(long n, decimal start, decimal end, Func<decimal, decimal> f)
        {
            decimal sn = Calculate(n, start, end, f);
            Console.WriteLine($"S{ n } = { sn }");
            decimal s2n = Calculate(2 * n, start, end, f);
            Console.WriteLine($"S{ 2 * n } = { s2n }");
            return ((s2n - sn) / 15) + s2n;
        }
    }
}
