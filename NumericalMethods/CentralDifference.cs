using System;

namespace NumericalMethods
{
    class CentralDifference
    {
        public static decimal Calculate(decimal x, decimal h, Func<decimal, decimal> f)
        {
            return (f(x + h) - f(x - h)) / (2 * h);
        }

        public static decimal Extrapolate(decimal ei, decimal ei2)
        {
            return ei2 + ((ei2 - ei) / 3);
        }

        public static decimal Extrapolate(decimal x, decimal h, Func<decimal, decimal> f)
        {
            return Extrapolate(Calculate(x, h, f), Calculate(x, h / 2m, f));
        }
    }
}
