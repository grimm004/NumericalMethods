using System;

namespace NumericalMethods
{
    class EulersStepMethod
    {
        public static decimal Calculate(decimal h, decimal x0, decimal y0, decimal x, Func<decimal, decimal, decimal> de)
        {
            decimal xN, yN = y0, yNPrime = 0;

            for (int n = 0; n < (x - x0) / h; n++)
            {
                xN = x0 + (n * h);
                yNPrime = de(xN, yN);
                yN = yN + (yNPrime * h);
            }

            return yN;
        }
    }
}
