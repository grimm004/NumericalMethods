using System;

namespace NumericalMethods
{
    class RearrangementMethod
    {
        /// <summary>
        /// Calculate an estimate for a root of a function
        /// </summary>
        /// <param name="n">The number of iterations to perform.</param>
        /// <param name="x">Value of x to iterate from.</param>
        /// <param name="rearrangedFunction">The equation rearranged as a function for x.</param>
        /// <returns>The estimate x-value for the root.</returns>
        public static double Calculate(int n, double x, Func<double, double> rearrangedFunction)
        {
            // Define a variable to store the next x value
            double nextX;
            // If the remaining iteration count is equal to zero return the current x value
            if (n == 0) nextX = x;
            // else set the next x value to the rearranged function result of the previous x value
            else nextX = rearrangedFunction(Calculate(n - 1, x, rearrangedFunction));
            // Ouput the next x value for this iteration
            Console.WriteLine($"x<{ n }>:\t{ nextX }");
            // Return the current x value
            return nextX;
        }
    }
}
