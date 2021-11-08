using System.Collections.Generic;
using System.Drawing;
using BaseLib;

namespace Base.WinForms.Extensions
{
    public static class GraphicsExtensions
    {
        public static Point ToPoint(this Vector2d v) => new((int)v.X, (int)v.Y);

        public static Vector2d Transform(this Vector2d v, Transformation2d t) => t.Apply(v);
        public static IEnumerable<Vector2d> Transform(this IEnumerable<Vector2d> v, Transformation2d t)
            => t.Apply(v);
    }
}
