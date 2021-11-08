using System;

namespace BaseLib
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

        // v = new Vector2d("(1.2323, -5)");
        public Vector2d(string s)
        {
            var del = new[] { ',', ' ', '(', ')' };

            var words = s.Split(del, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length != 2)
                throw new Exception();

            X = double.Parse(words[0]);
            Y = double.Parse(words[1]);
        }

        public static Vector2d operator +(Vector2d a, Vector2d b) => 
            new Vector2d(a.X + b.X, a.Y + b.Y);
        public static Vector2d operator -(Vector2d a, Vector2d b) =>
            new Vector2d(a.X - b.X, a.Y - b.Y);

        public static Vector2d operator *(Vector2d a, double s) =>
            new Vector2d(a.X * s, a.Y * s);
        public static Vector2d operator *(double s, Vector2d a) =>
            new Vector2d(a.X * s, a.Y * s);

        public static Vector2d operator /(Vector2d a, double s) =>
            new Vector2d(a.X / s, a.Y / s);

        public static double operator *(Vector2d a, Vector2d b) =>
            a.X * b.X + a.Y * b.Y;

        public double Length() => Math.Sqrt(X * X + Y * Y);

        public Vector2d Normalize()
        {
            var l = Length();

            X /= l;
            Y /= l;

            return this;
        }

        public Vector2d GetNormal()
        {
            var l = Length();
            return this * (1 / l);
        }


        public override string ToString() => $"({X},{Y})";
    }
}
