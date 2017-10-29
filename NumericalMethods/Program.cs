using System;


//static double F(double x)
//{
//    // half x cubed minus x squared minus five halfs x plus e
//    return (.5f * x * x * x) - (x * x) - (2.5f * x) + Math.E;
//    //return (x * x * x) - (4 * x * x) + (2 * x) + 2;
//}

//static double G(double x)
//{
//    return (2f * ((.5f * x * x * x) - (x * x) + Math.E)) / 5f;
//}

namespace NumericalMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0.48119;
            Console.WriteLine($"x = { x }");
            double x0 = x - 0.00005;
            double fx0 = F(x0);
            Console.WriteLine($"x = { x0 } => F(x) = { fx0 }");
            double x1 = x + 0.00005;
            double fx1 = F(x1);
            Console.WriteLine($"x = { x1 } => F(x) = { fx1 }");

            //int n = 20;
            //Console.WriteLine($"iterations: { n } { NewtonRaphson.Calculate(n, 0, F, Fprime) }");

            Console.ReadKey();
        }

        static double F(double x)
        {
            // negitive x cubed minus four x squared minus two x plus two
            return -(x * x * x) - (4 * x * x) - (2 * x) + 2;
        }

        static double Fprime(double x)
        {
            return -(3 * x * x) - (8 * x) - 2;
        }

        //static double F(double x)
        //{
        //    // one fifth x to the four plus x cubed minus x squard minus five x plus three
        //    return ((1 / 5) * x * x * x * x) + (x * x * x) - (x * x) - (5 * x) + 3;
        //}

        //static double Fp(double x)
        //{
        //    return ((4 / 5) * x * x * x) + (3 * x * x) - (2 * x) - 5;
        //}
    }
}
