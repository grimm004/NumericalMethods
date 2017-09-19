using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalMethods
{
    class FalsePosition
    {

        public static double Calculate(int n, double a, double b, Func<double, double> f)
        {
            if (n == 0) return FP(a, b, f);

            double c = Calculate(n - 1, a, b, f);

            if ((c > 0 && b > 0) || (c < 0 && b < 0)) b = c;
            if ((a > 0 && b > 0) || (a < 0 && b < 0)) a = c;

            return Calculate(n - 1, a, b, f);
        }

        protected static double FP(double a, double b, Func<double, double> f)
        {
            return ((a * f(b)) - (b * f(a))) / (f(b) - f(a));
        }
    }
}
