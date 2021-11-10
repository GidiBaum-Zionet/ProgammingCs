using System.Numerics;
using System.Runtime.CompilerServices;
using Base.WinForms;
using BaseLib;
using static BaseLib.MathFunctions;

namespace ShapeLib
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        //public Vector2d[] Points = new Vector2d[4];

        public Rectangle(double w, double h)
        {
            Width = w;
            Height = h;

            //Points[0] = new Vector2d(Center.X + w / 2, Center.Y + h / 2);
            //Points[1] = new Vector2d(Center.X - w / 2, Center.Y + h / 2);
            //Points[2] = new Vector2d(Center.X - w / 2, Center.Y - h / 2);
            //Points[3] = new Vector2d(Center.X + w / 2, Center.Y - h / 2);
        }

        public override void Draw(DrawContext dc)
        {
            var w2 = Width / 2;
            var h2 = Height / 2;

            dc.DrawPolygon(
                vec2(Center.X - w2, Center.Y - h2),
                vec2(Center.X + w2, Center.Y - h2),
                vec2(Center.X + w2, Center.Y + h2),
                vec2(Center.X - w2, Center.Y + h2)
            );

            //dc.DrawPolygon(Points);
        }
    }
}