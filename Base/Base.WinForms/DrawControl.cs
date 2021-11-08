using System;
using System.Drawing;
using System.Windows.Forms;

namespace Base.WinForms
{
    public partial class DrawControl : UserControl
    {
        public class DrawEventArgs : EventArgs
        {
            public DrawContext DrawContext { get; }

            public DrawEventArgs(DrawContext dc)
            {
                DrawContext = dc;
            }
        }
        public Transformation2d Transformation { get; } = new();

        public float MinX { get; set; } = -1;
        public float MaxX { get; set; } = 1;
        public float MinY { get; set; } = -1;
        public float MaxY { get; set; } = 1;

        public event EventHandler<DrawEventArgs> DrawEvent;


        public DrawControl()
        {
            InitializeComponent();
        }

        void DrawControl_Resize(object sender, EventArgs e)
        {
            Refresh();
        }

        void DrawControl_Paint(object sender, PaintEventArgs e)
        {
            Transformation.SetX(MinX, MaxX, Width);
            Transformation.SetY(MinY, MaxY, Height);

            DrawEvent?.Invoke(this, new DrawEventArgs(new DrawContext(this, e.Graphics)));
        }
    }
}
