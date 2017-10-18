using System;

namespace NumericalMethods
{
    class RearrangementMethod
    {
        public static double Calculate(int n, double x, Func<double, double> rearrangedFunction)
        {
            double nextX;
            if (n == 0) nextX = x;
            else nextX = rearrangedFunction(Calculate(n - 1, x, rearrangedFunction));
            Console.WriteLine($"x<{ n }>:\t{ nextX }");
            return nextX;
        }
    }
}
