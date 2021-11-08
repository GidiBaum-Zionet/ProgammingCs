using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ReSharper disable InconsistentNaming

namespace BaseLib
{
    public static class MathFunctions
    {
        public static double sqrt(double x) => Math.Sqrt(x);
        public static double sin(double x) => Math.Sin(x);

        public static Vector2d vec2(double x, double y) => 
            new Vector2d(x, y);
        public static Vector2d vec2(string s) =>
            new Vector2d(s);

    }
}
