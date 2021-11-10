using Base.WinForms;
using static BaseLib.MathFunctions;

namespace ShapeLib
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

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
        }
    }
}