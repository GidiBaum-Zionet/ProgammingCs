using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Base.WinForms.Extensions;
using BaseLib;

namespace Base.WinForms
{
    public class DrawContext
    {
        readonly DrawControl _Control;
        readonly Graphics _Graphics;

        public float LineWidth { get; set; } = 1;
        public float PointSize { get; set; } = 1;

        public Color LineColor { get; set; } = Color.Black;
        public Color FillColor { get; set; } = Color.Black;


        public DrawContext(DrawControl control, Graphics graphics)
        {
            _Control = control;
            _Graphics = graphics;
        }

        public void DrawPoints(IEnumerable<Vector2d> points) => DrawPoints(points.ToArray());

        public void DrawPoints(params Vector2d[] points)
        {
            var brush = new SolidBrush(FillColor);
            var d = PointSize;

            foreach (var p in points.Transform(_Control.Transformation))
            {
                _Graphics.FillEllipse(brush, (float)p.X - d/2, (float)p.Y - d / 2, d, d);
            }
        }

        public void DrawLines(IEnumerable<Vector2d> points) => DrawLines(points.ToArray());

        public void DrawLines(params Vector2d[] points)
        {
            var p0 = points[0].Transform(_Control.Transformation).ToPoint();

            var pen = new Pen(LineColor, LineWidth);

            for (var i = 1; i < points.Length; i++)
            {
                var p = points[i].Transform(_Control.Transformation).ToPoint();
                _Graphics.DrawLine(pen, p0, p);
                p0 = p;
            }
        }

        public void DrawLineLoop(IEnumerable<Vector2d> positions) => DrawLineLoop(positions.ToArray());

        public void DrawLineLoop(params Vector2d[] positions)
        {
            var points = positions.Select(p =>
                p.Transform(_Control.Transformation).ToPoint())
                .ToList();

            var pen = new Pen(LineColor, LineWidth);

            var n = points.Count;

            for (var i = 0; i < n; i++)
            {
                _Graphics.DrawLine(pen, points[i], points[(i + 1) % n]);
            }
        }

        public void DrawPolygon(IEnumerable<Vector2d> positions) => DrawPolygon(positions.ToArray());
        public void DrawPolygon(params Vector2d[] positions)
        {
            var points = positions.Select(p =>
                    p.Transform(_Control.Transformation).ToPoint())
                .ToArray();

            var brush = new SolidBrush(FillColor);

            _Graphics.FillPolygon(brush, points);
        }

        public void DrawCircle(Vector2d center, double radius)
        {
            var trans = _Control.Transformation;

            var c = center.Transform(trans).ToPoint();

            var brush = new SolidBrush(FillColor);

            _Graphics.FillEllipse(brush, (float)c.X, (float)c.Y,
                (float)(radius * trans.ScaleX), (float)(radius * trans.ScaleY));
        }

    }
}
