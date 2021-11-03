using System;

namespace ConsoleApp1
{
    class SqrtComputation
    {
        public static double Tolerance = 0.000001;

        public static double CalculateSqrt(double x)
        {
            if (x < 0)
            {
                throw new Exception("Negative values not supported");
            }

            var sqrt = 0.0;
            var min = 0.0;
            var max = x;

            var isRunning = true;

            while (isRunning)
            {
                sqrt = (min + max) / 2;

                var del = sqrt * sqrt - x;

                if (Math.Abs(del) < Tolerance)
                {
                    isRunning = false;
                }
                else
                {
                    (min, max) = (del < 0) ? (sqrt, max) : (min, sqrt);

                    //if (del < 0)
                    //{
                    //    min = sqrt;
                    //}
                    //else
                    //{
                    //    max = sqrt;
                    //}
                }
                Console.WriteLine($"running: {sqrt}");
            }

            return sqrt;
        }
    }
}