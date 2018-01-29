using System;

namespace NumericalMethods
{
    class DecimalSearch
    {
        /// <summary>
        /// Calculate an estimate for the root of an equation.
        /// </summary>
        /// <param name="n">The number of iterations to perform.</param>
        /// <param name="start">The start value.</param>
        /// <param name="end">The end value.</param>
        /// <param name="function">The equation in a function form.</param>
        /// <returns>The estimated root of the given function.</returns>
        public static decimal Calculate(decimal n, decimal start, decimal end, Func<decimal, decimal> function)
        {
            // Initialise a variable to hold the resultant estimate
            decimal estimate = 0;
            // Loop n - 2 times, each time providing the current power index
            for (decimal i = 1; i - 1 < n; i++)
            {
                Console.WriteLine($"index: { i } step: { 1 / Math.Pow(10, (double)i) }\tstart: { start }\tend: { end }\testimate: { estimate.ToString("0.0000000000") }");
                // Check if the function at the start value is negitive
                bool negitive = function(start) < 0;
                // Set through each sub-value of the current range
                for (decimal x = start; x < end; x += 1 / (decimal)Math.Pow(10d, (double)i))
                {
                    // Evaluate the function at the current x value
                    decimal fx = function(x);
                    // If the function was evaluated to zero return it as the solution
                    if (fx == 0m) return x;
                    // Else if the sign of the evaluated function is not equal to its previous sign (sign change)
                    else if (fx < 0m != negitive)
                    {
                        // Set the estimate to the current value of x
                        estimate = x;
                        // Set the new start position to the previous value of x
                        start = x - (1m / (decimal)Math.Pow(10, (double)i));
                        // Set the new end value to the current value of x
                        end = x;
                        // Break out of the current loop to change the step value to the next negitive power of 10
                        break;
                    }
                }
            }
            // Return the estimate
            return estimate;
        }
    }
}
