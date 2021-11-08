using System;
using System.Collections.Generic;
using System.Text;
using Base.WinForms;

namespace ShapeLib
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override void Draw(DrawContext dc)
        {
            dc.DrawCircle(Center, Radius);
        }
    }
}
