using System;

namespace NumericalMethods
{
    class SimpsonsRule
    {
        public static double Calculate(double tn, double mn)
        {
            return (tn + (2 * mn)) / 3;
        }

        public static double Calculate(long n, double start, double end, Func<double, double> f)
        {
            return (TrapeziumRule.Calculate(n, start, end, f) + (2 * MidpointRule.Calculate(n, start, end, f))) / 3;
        }

        public static double GetRatio(long n, double start, double end, Func<double, double> f)
        {
            double sn = Calculate(n, start, end, f);
            double s2n = Calculate(2 * n, start, end, f);
            double s4n = Calculate(4 * n, start, end, f);
            return (s4n - s2n) / (s2n - sn);
        }

        public static double ExtrapolationToIninity(double sn, double s2n)
        {
            return ((s2n - sn) / 15) + s2n;
        }

        public static double ExtrapolationToIninity(long n, double start, double end, Func<double, double> f)
        {
            double sn = Calculate(n, start, end, f);
            Console.WriteLine($"S{ n } = { sn }");
            double s2n = Calculate(2 * n, start, end, f);
            Console.WriteLine($"S{ 2 * n } = { s2n }");
            return ((s2n - sn) / 15) + s2n;
        }
    }
}
