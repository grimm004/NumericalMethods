using System;

namespace NumericalMethods
{
    class RearrangementMethod
    {
        public static double Calculate(int n, double x, Func<double, double> function)
        {
            if (n == 0) return x;
            else return function(Calculate(n - 1, x, function));
        }
    }
}
