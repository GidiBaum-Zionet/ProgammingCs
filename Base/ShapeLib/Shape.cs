using System;
using System.Drawing;
using Base.WinForms;
using BaseLib;

namespace ShapeLib
{
    public abstract class Shape
    {
        public Color Color { get; set; }

        public Vector2d Center { get; set; }

        public abstract void Draw(DrawContext dc);
    }
}
