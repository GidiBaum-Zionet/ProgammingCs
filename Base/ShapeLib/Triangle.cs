using Base.WinForms;
using BaseLib;

namespace ShapeLib
{
    public class Triangle : Shape
    {
        public Vector2d[] Points { get; set; }

        public Triangle()
        {
            Points = new Vector2d[3];
        }
        public Triangle(Vector2d p0, Vector2d p1, Vector2d p2)
        {
            Points = new Vector2d[3];
            Points[0] = p0;
            Points[1] = p1;
            Points[2] = p2;
        }

        public override void Draw(DrawContext dc)
        {
            //dc.DrawLineLoop(Points);
            dc.DrawPolygon(Points);
        }
    }
}