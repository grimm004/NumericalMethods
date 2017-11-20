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
            //double x = 0.48119;
            //Console.WriteLine($"x = { x }");
            //double x0 = x - 0.000005;
            //double fx0 = F(x0);
            //Console.WriteLine($"x = { x0 } => F(x) = { fx0 }");
            //double x1 = x + 0.000005;
            //double fx1 = F(x1);
            //Console.WriteLine($"x = { x1 } => F(x) = { fx1 }");

            //Console.WriteLine($"iterations: { 10 } { DecimalSearch.Calculate(10, 0, 1, F) }");
            //Console.WriteLine($"iterations: { 100 } { RearrangementMethod.Calculate(100, 0, G) }");
            //Console.WriteLine($"iterations: { 20 } { NewtonRaphson.Calculate(20, 0, F, Fprime) }");

            //Console.WriteLine($"{ 0x2000000 } { SimpsonsRule.Calculate(0x2000000, 1, (decimal)Math.E, F).ToString("0.00000000000000000000") }");

            Console.WriteLine(EulersStepMethod.Calculate(0.1m, 1m, 0m, 2m, DyDx));

            Console.ReadKey();
        }

        static decimal DyDx(decimal x, decimal y)
        {
            return ((decimal)Math.Cos((double)x) - (3 * x * (y + (0.1m * y * y)))) / (x * x);
        }

        static decimal F(decimal x)
        {
            // negitive x cubed minus four x squared minus two x plus two
            //return -(x * x * x) - (4 * x * x) - (2 * x) + 2;
            return (1 / x);
        }

        static double Fprime(double x)
        {
            return -(3 * x * x) - (8 * x) - 2;
        }

        //static double G(double x)
        //{
        //    // Rearranged function
        //    return Math.Pow((.5f * x * x * x) - (2.5f * x) + Math.E, .5);
        //}

        static double G(double x)
        {
            // Rearranged function
            return Math.Pow(2 * ((x * x) + (2.5f * x) - Math.E), 1f / 3d);
        }

        //static double F(double x)
        //{
        //    // negitive three x cubed plus two x squard plus half x minus one fifth
        //    return -(3 * x * x * x) + (2 * x * x) + (.5 * x) - .2;
        //}

        //static double Fprime(double x)
        //{
        //    return -(9 * x * x) + (4 * x) + .5;
        //}

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
//using System;

////return (x * x * x) - (4 * x * x) + (2 * x) + 2;
//namespace NumericalMethods
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int n = 50;
//            Console.WriteLine($"iterations: { n } { RearrangementMethod.Calculate(n, 2, G) }");
//            Console.ReadKey();
//        }

//        static double F(double x)
//        {
//            // half x cubed minus x squared minus two fifths x plus e
//            return (.5f * x * x * x) - (x * x) - (2.5f * x) + Math.E;
//        }

//        //static double G(double x)
//        //{
//        //    // Rearranged function
//        //    return Math.Pow((.5f * x * x * x) - (2.5f * x) + Math.E, .5);
//        //}

//        static double G(double x)
//        {
//            // Rearranged function
//            return Math.Pow(2 * ((x * x) + (2.5f * x) - Math.E), 1f / 3d);
//        }

//        //static double G(double x)
//        //{
//        //    // Rearranged function
//        //    return (2f * ((.5f * x * x * x) - (x * x) + Math.E)) / 5f;
//        //}
//    }
//}
