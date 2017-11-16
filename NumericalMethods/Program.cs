using System;

//return (x * x * x) - (4 * x * x) + (2 * x) + 2;
namespace NumericalMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SimpsonsRule.ExtrapolationToIninity(0b111111111111111111111110, 0, 20, F));
            Console.ReadKey();
        }

        static double F(double x)
        {
            return Math.Pow(Math.E, -(x * x));
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

        //static double G(double x)
        //{
        //    // Rearranged function
        //    return (2f * ((.5f * x * x * x) - (x * x) + Math.E)) / 5f;
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
