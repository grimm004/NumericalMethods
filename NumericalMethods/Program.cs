using System;

namespace NumericalMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Run the function to calculate and output integral estimates
            NumericalIntegration(20, 0, (decimal)(Math.PI / 2d));
            // Halt the program
            Console.ReadKey();
        }

        static decimal F(decimal x)
        {
            // Calculate and return the value for the function at x
            // ln(sin(cos(e^(-x^2))))
            // natural log of the sine of the cosine of e to the negative x squared
            return (decimal)Math.Log(Math.Sin(Math.Cos(Math.Pow(Math.E, (double)-(x * x)))));
        }

        static void NumericalIntegration(int maximumPowerIndex, decimal start, decimal end)
        {
            // Define and initialize the arrays of all the data to be collected
            decimal[] m, t, s, r, eA, eR;
            m = new decimal[maximumPowerIndex];
            t = new decimal[maximumPowerIndex];
            s = new decimal[maximumPowerIndex];
            r = new decimal[maximumPowerIndex];
            eA = new decimal[maximumPowerIndex];
            eR = new decimal[maximumPowerIndex];

            // Define and initialize the current strip count holder
            long n = 1;
            // Define and initialize the current index (for the array storage)
            int i = 0;
            // Calculate initial values for the trapezium, midpoint and simpsons rule
            // This is not included in the below loop so that the second method of
            // calculating the trapezium rule can be used for remaining estimates.
            t[i] = TrapeziumRule.Calculate(n, start, end, F);
            m[i] = MidpointRule.Calculate(n, start, end, F);
            s[i] = SimpsonsRule.Calculate(t[i], m[i]);

            // Loop through each power of two up until the desired power
            for (i = 1; i < maximumPowerIndex; i++)
            {
                // Multiply n by two
                n *= 2;
                // Calculated the next estimates using the numerical methods
                t[i] = TrapeziumRule.Calculate(m[i - 1], t[i - 1]);
                m[i] = MidpointRule.Calculate(n, start, end, F);
                s[i] = SimpsonsRule.Calculate(t[i], m[i]);
                // If the current index is greater than 1, calculate the ratio of differences
                if (i > 1) r[i] = SimpsonsRule.GetRatio(s[i - 2], s[i - 1], s[i]);
            }

            // 
            decimal acceptedValue = s[s.Length - 1];
            Console.WriteLine("Taking accepted value to be I = {0:0.00000000000000000000}", acceptedValue);

            for (i = 0; i < maximumPowerIndex; i++)
            {
                eA[i] = Math.Abs(s[i] - acceptedValue);
                eR[i] = eA[i] / acceptedValue;
            }

            n = 1;
            for (i = 0; i < maximumPowerIndex; i++)
            {
                n *= 2;
                Console.Write("i: {0}, n: {1}, tn: {2:0.00000000000000000000}, mn: {3:0.00000000000000000000}, sn: {4:0.00000000000000000000} ", i, n, t[i], m[i], s[i]);
                Console.Write("eA: {0:0.00000000000000000000}, eR: {1:0.00000000000000000000}% ", eA[i], 100 * eR[i]);
                if (i > 1) Console.WriteLine("RoD: {0:0.00000000000000000000}", r[i]);
                else Console.WriteLine();
            }
        }
    }
}