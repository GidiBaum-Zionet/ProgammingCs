using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    public class Vector2d
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vector2d()
        {
        }

        public Vector2d(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static Vector2d operator +(Vector2d a, Vector2d b) => 
            new Vector2d(a.X + b.X, a.Y + b.Y);

        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }
}
